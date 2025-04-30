using System;
using UnityEngine;

namespace VirtualMaker.Bindings
{
    /// <summary>
    /// IProperty that tweens to and from values over time and animation curves
    /// </summary>
    public class Tween<T> : IProperty<T>
    {
        public delegate T Lerp(T a, T b, float t);

        public T Value { get => _current.Value; set => GoTo(value); }

        public event Action<T> OnChange
        {
            add { _current.OnChange += value; }
            remove { _current.OnChange -= value; }
        }

        public event Action OnComplete;

        private T _target;
        private T _source;
        private Property<T> _current = new();
        private float _duration = 1;
        private float _startTime;
        private AnimationCurve _curve = AnimationCurve.Linear(0, 0, 1, 1);
        private Awaitable _awaitable;
        private Lerp _lerp;
        private bool _done;

        public Tween(T value, Lerp lerp)
        {
            _current.Value = value;
            _lerp = lerp;
        }

        public void Reset()
        {
            if (_awaitable != null && !_awaitable.IsCompleted)
            {
                _awaitable.Cancel();
            }

            _awaitable = null;
        }

        ~Tween()
        {
            Reset();
        }

        private async Awaitable PerformTween()
        {
            try
            {
                while (!_done)
                {
                    var t = (Time.time - _startTime) / _duration;

                    if (t >= 1)
                    {
                        _done = true;
                        _current.Value = _target;
                        OnComplete?.Invoke();
                        return;
                    }
                    else
                    {
                        _current.Value = _lerp(_source, _target, _curve.Evaluate(t));
                    }

                    await Awaitable.NextFrameAsync();
                }
            }
            catch (OperationCanceledException) {}
        }

        public void GoTo(T value)
            => GoFromTo(_current.Value, value, _duration);

        public void GoTo(T value, float duration)
            => GoFromTo(_current.Value, value, duration);

        public void GoTo(T value, float duration, AnimationCurve curve)
            => GoFromTo(_current.Value, value, duration, curve);

        public void GoFromTo(T from, T to)
            => GoFromTo(from, to, _duration, AnimationCurve.Linear(0, 0, 1, 1));

        public void GoFromTo(T from, T to, float duration)
            => GoFromTo(from, to, duration, AnimationCurve.Linear(0, 0, 1, 1));

        public async Awaitable GoFromToAsync(T from, T to, float duration)
            => await GoFromToAsync(from, to, duration, AnimationCurve.Linear(0, 0, 1, 1));

        public async void GoFromTo(T from, T to, float duration, AnimationCurve curve)
            => await GoFromToAsync(from, to, duration, curve);

        public async Awaitable GoFromToAsync(T from, T to, float duration, AnimationCurve curve)
        {
            if (_awaitable != null && !_awaitable.IsCompleted)
            {
                _awaitable.Cancel();
            }

            _duration = duration;
            _startTime = Time.time;
            _curve = curve;
            _source = from;
            _target = to;
            _done = false;
            _awaitable = PerformTween();
            await _awaitable;
        }
    }

    public class TweenFloat : Tween<float>
    {
        public TweenFloat(float value = 0) : base(value, Mathf.Lerp) { }
    }

    public class TweenVector3 : Tween<Vector3>
    {
        public TweenVector3(Vector3 value) : base(value, Vector3.Lerp) { }
    }

    public class TweenQuaternion : Tween<Quaternion>
    {
        public TweenQuaternion(Quaternion value) : base(value, Quaternion.Slerp) { }
    }
}
