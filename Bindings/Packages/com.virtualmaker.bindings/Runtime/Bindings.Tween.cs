using System;
using System.Threading.Tasks;
using UnityEngine;

namespace VirtualMaker.Bindings
{
    internal class PropertyUpdater
    {
        private Action _updateFunc;
        private Func<bool> _doneFunc;
        private bool _cancelled;

        private Task _task;
        public Task Task => _task;

        public PropertyUpdater(Action updateFunc, Func<bool> doneFunc = null)
        {
            _updateFunc = updateFunc;
            _doneFunc = doneFunc;
            _task = RunAsync();
        }

        public void Reset()
        {
            _cancelled = true;
        }

        private async Task RunAsync()
        {
            while (!_cancelled && (_doneFunc == null || !_doneFunc()))
            {
                _updateFunc();
                await Awaitable.NextFrameAsync();
            }
        }
    }

    public partial class Bindings
    {
        // These functions will update property or value every frame, with an optional exit condition.

        public void BindUpdate(Action updateFunc, Func<bool> doneFunc = null)
        {
            var updater = new PropertyUpdater(updateFunc, doneFunc);
            _unsubscribe.Add(() => updater.Reset());
        }

        public void BindUpdate<T>(Property<T> property, Func<T> valueFunc, Func<bool> doneFunc = null)
            => BindUpdate(() => property.Value = valueFunc(), doneFunc);

        public void BindMoveTowards(Property<Vector3> property, IProperty<Vector3> fromProperty, float rate)
            => BindUpdate(property, () => Vector3.MoveTowards(property.Value, fromProperty.Value, rate * Time.smoothDeltaTime));

        public void BindMoveTowards(Transform transform, IProperty<Vector3> fromProperty, float rate)
            => BindUpdate(
                () => transform.position = Vector3.MoveTowards(transform.position, fromProperty.Value, rate * Time.smoothDeltaTime));

        public IProperty<T> CreateUpdateProperty<T>(Func<T> updateFunc, Func<bool> doneFunc = null)
        {
            var property = new Property<T>();
            BindUpdate(property, updateFunc, doneFunc);
            return property;
        }

        // These async functions will update the property or value until an exit condition is met.

        public async Task UpdateAsync(Action updateFunc, Func<bool> doneFunc)
        {
            var updater = new PropertyUpdater(updateFunc, doneFunc);
            _unsubscribe.Add(() => updater.Reset());
            await updater.Task;
        }

        public async Task UpdateAsync<T>(Property<T> property, Func<T> updateFunc, Func<bool> doneFunc)
            => await UpdateAsync(() => property.Value = updateFunc(), doneFunc);

        public async Task MoveTowardsAsync(Property<Vector3> property, Vector3 target, float rate)
            => await UpdateAsync(property,
                () => Vector3.MoveTowards(property.Value, target, rate * Time.smoothDeltaTime),
                () => property.Value == target);

        public async Task MoveTowardsAsync(Transform transform, Vector3 target, float rate)
            => await UpdateAsync(
                () => transform.position = Vector3.MoveTowards(transform.position, target, rate * Time.smoothDeltaTime),
                () => transform.position == target);
    }
}