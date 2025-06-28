// Enable this to add editor menu items that can generate
#if true

using System;
using System.Linq;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.Reflection;

namespace VirtualMaker.Bindings
{
    internal static class BindingsCodeGen
    {
        const string BasePath = "C:\\repos\\com.virtualmaker.bindings\\Bindings\\Packages\\com.virtualmaker.bindings\\Runtime\\";

        private static Dictionary<string, string[]> GetUnityComponents()
        {
            var components = new Dictionary<string, string[]>();
            var json = System.IO.File.ReadAllText(BasePath + "UnityComponents.json");
            var jsonText = json.Replace(" ", "").Replace("\r", "").Replace("\t", "").Replace("\n", "");
            var index = 0;
            while (true)
            {
                var q1 = jsonText.IndexOf('"', index);
                var q2 = jsonText.IndexOf('"', q1 + 1);
                var a1 = jsonText.IndexOf('[', q2 + 1);
                var a2 = jsonText.IndexOf(']', a1 + 1);

                if (q1 == -1 || q2 == -1 || a1 == -1 || a2 == -1)
                {
                    break;
                }

                var name = jsonText.Substring(q1 + 1, q2 - q1 - 1);
                var properties = jsonText.Substring(a1 + 1, a2 - a1 - 1).Split(',').Select(x => x.Trim('"')).ToArray();
                components.Add(name, properties);
                index = a2 + 1;
            }

            return components;
        }

        private static Type GetType(string name)
        {
            foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (var type in a.GetTypes())
                {
                    if (type.IsSubclassOf(typeof(UnityEngine.Component)) &&
                        (type.FullName == name || type.FullName.EndsWith("." + name)))
                    {
                        return type;
                    }
                }
            }

            throw new Exception("Unknown Type: " + name);
        }

        private static string GeneratePropertyInfo(Type componentType, string prop, string name)
        {
            string define = null;
            var split = prop.Split(':');
            if (split.Length > 1)
            {
                define = split[0];
                prop = split[1];
            }

            // Check if typename is specified. This is to catch properties which change type between versions.
            string typeName = null;
            if (prop.Contains("|"))
            {
                var split2 = prop.Split('|');
                prop = split2[0];
                typeName = split2[1];
            }

            var tab = "        ";
            var s = "";

            if (define != null)
            {
                s += tab + $"#if {define}" + Environment.NewLine;
            }

            var propertyInfo = componentType.GetProperty(prop);
            var fieldInfo = componentType.GetField(prop);

            Debug.Log($"Generating {prop} for {name}");
            if (propertyInfo == null && fieldInfo == null)
            {
                Debug.LogWarning($"Can't find property {prop} on {name}");
                return "";
            }

            var propertyType = propertyInfo?.PropertyType ?? fieldInfo.FieldType;

            if (typeName == null)
            {
                typeName = propertyType.FullName;
                if (propertyType.IsGenericType)
                {
                    Type genericType = propertyType.GetGenericTypeDefinition();
                    string typeArgument = propertyType.GetGenericArguments()[0].FullName;
                    typeName = genericType.FullName.Split('`')[0] + "<" + typeArgument + ">";
                }

                typeName = typeName.Replace("+", ".");
            }

            var prettyProp = prop[0].ToString().ToUpper() + prop[1..];
            bool isString = typeName == "System.String";
            var suffix = isString ? ".ToString()" : "";
            var generic = isString ? "<T>" : "";
            var propType = isString ? "T" : typeName;

            s += tab + $"public static void Bind{prettyProp}{generic}(this {name} obj, Bindings2 bindings, IProperty<{propType}> property)" + Environment.NewLine;
            s += tab +  $"    => bindings.Bind(property, v => obj.{prop} = v{suffix});" + Environment.NewLine;

            s += tab + $"public static void Bind{prettyProp}{generic}(this {name} obj, IProperty<{propType}> property)" + Environment.NewLine;
            s += tab + $"    => Bind{prettyProp}(obj, Bindings2._scope, property);" + Environment.NewLine;

            s += tab + $"public static void Bind{prettyProp}{generic}(this {name} obj, Bindings2 bindings, Func<{propType}> func)" + Environment.NewLine;
            s += tab +  $"    => bindings.BindUpdate(() => obj.{prop} = func(){suffix});" + Environment.NewLine;

            s += tab + $"public static void Bind{prettyProp}{generic}(this {name} obj, Func<{propType}> func)" + Environment.NewLine;
            s += tab + $"    => Bind{prettyProp}(obj, Bindings2._scope, func);" + Environment.NewLine;

            s += tab + $"public static void Bind{prettyProp}Interval{generic}(this {name} obj, Bindings2 bindings, float seconds, Func<{propType}> func)" + Environment.NewLine;
            s += tab +  $"    => bindings.BindInterval(seconds, () => obj.{prop} = func(){suffix});" + Environment.NewLine;

            s += tab + $"public static void Bind{prettyProp}Interval{generic}(this {name} obj, float seconds, Func<{propType}> func)" + Environment.NewLine;
            s += tab + $"    => Bind{prettyProp}Interval(obj, Bindings2._scope, seconds, func);" + Environment.NewLine;

            if (typeName == "UnityEngine.Vector3")
            {
                // Vector3.Lerp

                s += tab + $"public static void Bind{prettyProp}Lerp(this {name} obj, Bindings2 bindings, float speed, Property<{propType}> property)" + Environment.NewLine;
                s += tab +  $"    => bindings.BindUpdate(() => obj.{prop} = Vector3.Lerp(obj.{prop}, property.Value, speed * Time.smoothDeltaTime));" + Environment.NewLine;

                s += tab + $"public static void Bind{prettyProp}Lerp(this {name} obj, float speed, Property<{propType}> property)" + Environment.NewLine;
                s += tab + $"    => Bind{prettyProp}Lerp(obj, Bindings2._scope, speed, property);" + Environment.NewLine;

                s += tab + $"public static void Bind{prettyProp}Lerp(this {name} obj, Bindings2 bindings, float speed, Func<{propType}> func)" + Environment.NewLine;
                s += tab +  $"    => bindings.BindUpdate(() => obj.{prop} = Vector3.Lerp(obj.{prop}, func(), speed * Time.smoothDeltaTime));" + Environment.NewLine;

                s += tab + $"public static void Bind{prettyProp}Lerp(this {name} obj, float speed, Func<{propType}> func)" + Environment.NewLine;
                s += tab + $"    => Bind{prettyProp}Lerp(obj, Bindings2._scope, speed, func);" + Environment.NewLine;

                // Vector3.MoveTowards

                s += tab + $"public static void Bind{prettyProp}Towards(this {name} obj, Bindings2 bindings, float speed, Property<{propType}> property)" + Environment.NewLine;
                s += tab +  $"    => bindings.BindUpdate(() => obj.{prop} = Vector3.MoveTowards(obj.{prop}, property.Value, speed * Time.smoothDeltaTime));" + Environment.NewLine;

                s += tab + $"public static void Bind{prettyProp}Towards(this {name} obj, float speed, Property<{propType}> property)" + Environment.NewLine;
                s += tab + $"    => Bind{prettyProp}Towards(obj, Bindings2._scope, speed, property);" + Environment.NewLine;

                s += tab + $"public static void Bind{prettyProp}Towards(this {name} obj, Bindings2 bindings, float speed, Func<{propType}> func)" + Environment.NewLine;
                s += tab +  $"    => bindings.BindUpdate(() => obj.{prop} = Vector3.MoveTowards(obj.{prop}, func(), speed * Time.smoothDeltaTime));" + Environment.NewLine;

                s += tab + $"public static void Bind{prettyProp}Towards(this {name} obj, float speed, Func<{propType}> func)" + Environment.NewLine;
                s += tab + $"    => Bind{prettyProp}Towards(obj, Bindings2._scope, speed, func);" + Environment.NewLine;

                // Animation

                s += tab + $"public static void Animate{prettyProp}(this {name} obj, Bindings2 bindings, {propType} start, {propType} end, AnimationCurve curve)" + Environment.NewLine;
                s += tab +  $"    => bindings.Animate(curve, t => obj.{prop} = Vector3.Lerp(start, end, t));" + Environment.NewLine;

                s += tab + $"public static void Animate{prettyProp}(this {name} obj, {propType} start, {propType} end, AnimationCurve curve)" + Environment.NewLine;
                s += tab +  $"    => Animate{prettyProp}(obj, Bindings2._scope, start, end, curve);" + Environment.NewLine;

                s += tab + $"public static void Animate{prettyProp}(this {name} obj, Bindings2 bindings, {propType} end, AnimationCurve curve)" + Environment.NewLine;
                s += tab +  $"    => Animate{prettyProp}(obj, Bindings2._scope, obj.{prop}, end, curve);" + Environment.NewLine;

                s += tab + $"public static void Animate{prettyProp}(this {name} obj, {propType} end, AnimationCurve curve)" + Environment.NewLine;
                s += tab +  $"    => Animate{prettyProp}(obj, Bindings2._scope, end, curve);" + Environment.NewLine;
            }

            if (define != null)
            {
                s += tab + $"#endif" + Environment.NewLine;
            }
            return s;
        }

        [MenuItem("Bindings/Generate Extensions")]
        private static void GenerateExtensions()
        {
            var text = System.IO.File.ReadAllText(BasePath + "Bindings.Extensions.Template.cs");
            var components = GetUnityComponents();

            var code = string.Join(Environment.NewLine + Environment.NewLine,
                components.Select(kv => {
                    var name = kv.Key;
                    var split = name.Split(':');
                    string define = null;
                    if (split.Length > 1)
                    {
                        define = split[0];
                        name = split[1];
                    }

                    var s = "";
                    if (define != null)
                    {
                        s += $"        #if {define}" + Environment.NewLine;
                    }

                    var componentType = GetType(name);

                    foreach (var prop in kv.Value)
                    {
                        s += GeneratePropertyInfo(componentType, prop, name);
                    }

                    if (define != null)
                    {
                        s += $"        #endif" + Environment.NewLine;
                    }

                    return s;
                }));

            text = text.Replace("        // <Auto-generated>" + Environment.NewLine, code);
            var preservePath = BasePath + "Bindings.Extensions.Generated.cs";
            System.IO.File.WriteAllText(preservePath, text);
            AssetDatabase.Refresh();
        }
    }
}

#endif