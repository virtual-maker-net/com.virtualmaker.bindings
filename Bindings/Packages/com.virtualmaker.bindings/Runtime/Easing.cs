using System.Security.Cryptography;
using UnityEngine;

namespace VirtualMaker.Bindings
{
    public static class Easing
    {
        public static AnimationCurve Linear(float time) => AnimationCurve.Linear(0, 0, time, 1);
        public static AnimationCurve EaseInOut(float time) => AnimationCurve.EaseInOut(0, 0, time, 1);

        public static AnimationCurve EaseOut(float time)
        {
            if (time == 0)
            {
                Keyframe keyframe = new Keyframe(0, 0);
                return new AnimationCurve(keyframe);
            }

            float num = 1 / time;
            Keyframe[] array = new Keyframe[2]
            {
                new Keyframe(0, 0, 0f, num),
                new Keyframe(time, 1, 0f, 0f)
            };

            return new AnimationCurve(array);
        }

        public static AnimationCurve EaseIn(float time)
        {
            if (time == 0)
            {
                Keyframe keyframe = new Keyframe(0, 0);
                return new AnimationCurve(keyframe);
            }

            float num = 1 / time;
            Keyframe[] array = new Keyframe[2]
            {
                new Keyframe(0, 0, 0, 0),
                new Keyframe(time, 1, num, 0f)
            };

            return new AnimationCurve(array);
        }

        public static AnimationCurve Reverse(AnimationCurve curve)
        {
            var keys = new Keyframe[curve.keys.Length];
            var totalTime = curve.keys[^1].time;
            for (int i = 0; i < curve.keys.Length; i++)
            {
                var k = curve.keys[^(i + 1)];
                keys[i] = new Keyframe(totalTime - k.time, k.value, k.outTangent, k.inTangent);
            }

            return new AnimationCurve(keys);
        }
    }
}