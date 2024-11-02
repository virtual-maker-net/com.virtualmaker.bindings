using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VirtualMaker.Bindings
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class PropertyRangeAttribute : PropertyAttribute
    {
        public float min;
        public float max;

        public PropertyRangeAttribute(float _min, float _max)
        {
            min = _min;
            max = _max;
        }
    }
}