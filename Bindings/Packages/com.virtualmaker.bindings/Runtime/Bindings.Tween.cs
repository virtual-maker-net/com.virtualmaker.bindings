using System;
using System.Threading.Tasks;
using UnityEngine;

namespace VirtualMaker.Bindings
{
    public class PropertyUpdater
    {
        private Task _task;
        private Action _updateFunc;
        private Func<bool> _doneFunc;
        private bool _cancelled;

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

        ~PropertyUpdater()
        {
            Reset();
        }

        public Task WaitAsync() => _task;
    }

    public partial class Bindings
    {
        public PropertyUpdater LinearUpdate(Property<Vector3> property, Vector3 target, float rate)
        {
            var updater = new PropertyUpdater(
                () => property.Value = Vector3.MoveTowards(property.Value, target, rate * Time.smoothDeltaTime),
                () => property.Value == target);

            _unsubscribe.Add(() => updater.Reset());
            return updater;
        }

        public void BindMoveTowards(Property<Vector3> property, IProperty<Vector3> fromProperty, float rate)
        {
            var updater = new PropertyUpdater(
                () => property.Value = Vector3.MoveTowards(property.Value, fromProperty.Value, rate * Time.smoothDeltaTime));

            _unsubscribe.Add(() => updater.Reset());
        }

        public void BindMoveTowards(Transform transform, IProperty<Vector3> fromProperty, float rate)
        {
            var updater = new PropertyUpdater(
                () => transform.position = Vector3.MoveTowards(transform.position, fromProperty.Value, rate * Time.smoothDeltaTime));

            _unsubscribe.Add(() => updater.Reset());
        }

        public void BindUpdate<T>(Property<T> property, Func<T> func)
        {
            var updater = new PropertyUpdater(() => property.Value = func());
            _unsubscribe.Add(() => updater.Reset());
        }

        public IProperty<T> CreateUpdateProperty<T>(Func<T> func)
        {
            var property = new Property<T>();
            BindUpdate(property, func);
            return property;
        }

        public void BindUpdate(Action action)
        {
            var updater = new PropertyUpdater(action);
            _unsubscribe.Add(() => updater.Reset());
        }
    }
}