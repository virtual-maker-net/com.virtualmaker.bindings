using UnityEngine;

namespace VirtualMaker.Bindings
{
    public static class Easing
    {
        public static AnimationCurve Linear(float time) => AnimationCurve.Linear(0, 0, time, 1);
        public static AnimationCurve EaseInOut(float time) => AnimationCurve.EaseInOut(0, 0, time, 1);
    }
}