using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace GameMain
{
    public static class MyExtensions
    {
        public static T GetAttribute<T>(this ICustomAttributeProvider assembly, bool inherit = false)
            where T : Attribute
        {
            return assembly.GetCustomAttributes(typeof(T), inherit)
                .OfType<T>()
                .FirstOrDefault();
        }

        public static object GetPropertieValue<T>(this T t, string property)
        {
            if (t == null || property.IsEmpty())
            {
                return null;
            }

            var item = t.GetType().GetProperty(property);
            object value = item?.GetValue(t, null);
            return value;
        }

        /// <summary>
        /// 将不相同的值进行填充
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="F"></typeparam>
        /// <param name="to"></param>
        /// <param name="from"></param>
        public static void Fill<T, F>(this T to, F from)
            where T : class
        {
            var tTo = typeof(T);
            var psFrom = typeof(F).GetProperties();
            foreach (var pFrom in psFrom)
            {
                var vFrom = pFrom.GetValue(from);
                if (vFrom != null)
                {
                    var pTo = tTo.GetProperty(pFrom.Name);
                    if (pTo != null)
                    {
                        var vvTo = pTo.GetValue(to);
                        var pToType = pTo.PropertyType;
                        if (pToType.IsGenericType && pToType.GetGenericTypeDefinition() == typeof(Nullable<>))
                        {
                            var vTo = Convert.ChangeType(vFrom, pToType.GetGenericArguments()[0]);
                            if (!ObjEquals(vvTo, vTo))
                                pTo.SetValue(to, vTo);
                        }
                        else
                        {
                            var vTo = Convert.ChangeType(vFrom, pTo.PropertyType);
                            if (!ObjEquals(vvTo, vTo))
                                pTo.SetValue(to, vTo);
                        }
                    }
                }
            }
        }

        public static bool ObjEquals(object objA, object objB)
        {
            if (objA == objB)
            {
                return true;
            }
            if (objA != null && objB != null)
            {
                return objA.Equals(objB);
            }
            return false;
        }


        /// <summary> 
        /// 将 Stream 转成 byte[] 
        /// </summary> 
        public static byte[] ToBytes(this Stream stream)
        {
            byte[] bytes = new byte[stream.Length];
            stream.Read(bytes, 0, bytes.Length);

            // 设置当前流的位置为流的开始 
            stream.Seek(0, SeekOrigin.Begin);
            return bytes;
        }

        /// <summary>
        /// 扩展方法判断是否为空或者为null
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsEmpty(this string str)
        {
            return string.IsNullOrWhiteSpace(str) || string.IsNullOrEmpty(str);
        }

        /// <summary>
        /// 扩展方法判断是否为空或者为null
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNotEmpty(this string str)
        {
            return !str.IsEmpty();
        }

        public static bool In(this string str, IEnumerable<string> strArray)
        {
            return strArray.Contains(str);
        }

        public static bool In(this string str, params string[] strArray)
        {
            return strArray.Contains(str);
        }

        public static bool NotIn(this string str, IEnumerable<string> strArray)
        {
            return !strArray.Contains(str);
        }

        public static bool NotIn(this string str, params string[] strArray)
        {
            return !strArray.Contains(str);
        }

        /// <summary>
        /// 扩展方法判断是否为空或者为null
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static bool IsEmpty(this string[] array)
        {
            return array == null || array.Length == 0;
        }

        /// <summary>
        /// 扩展方法判断是否为空或者为null
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static bool IsNotEmpty(this string[] array)
        {
            return !array.IsEmpty();
        }

        /// <summary>
        /// 扩展方法判断是否为空或者为null
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static bool IsEmpty(this int[] array)
        {
            return array == null || array.Length == 0;
        }

        /// <summary>
        /// 扩展方法判断是否为空或者为null
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static bool IsNotEmpty(this int[] array)
        {
            return !array.IsEmpty();
        }

        /// <summary>
        /// 转换为Enum
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T ToEnum<T>(this string value)
            where T : Enum
        {
            int iv;
            if (int.TryParse(value, out iv))
            {
                return (T)Enum.ToObject(typeof(T), iv);
            }
            else
            {
                return (T)Enum.Parse(typeof(T), value);
            }
        }

        /// <summary>
        /// 转换为Enum
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T ToEnum<T>(this int value)
            where T : Enum
        {
            return (T)Enum.ToObject(typeof(T), value);
        }

        /// <summary>
        /// 字符中汉字数量
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int CNCharCount(this string str)
        {
            var mc = Regex.Matches(str, "[\u4e00-\u9fa5]");
            int count = mc.Count;//汉字个数
            return count;
        }

        /// <summary>
        /// 首字母小写
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string FirstCharToLower(this string str)
        {
            return str.IsEmpty() ? str : str.First().ToString().ToLower() + str.Substring(1);
        }

        /// <summary>
        /// 首字母大写
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string FirstCharToUpper(this string str)
        {
            return str.IsEmpty() ? str : str.First().ToString().ToUpper() + str.Substring(1);
        }

        public static string ToDescription(this Enum value)
        {
            if (value == null)
                return "";

            System.Reflection.FieldInfo fieldInfo = value.GetType().GetField(value.ToString());

            object[] attribArray = fieldInfo.GetCustomAttributes(false);
            if (attribArray.Length == 0)
                return value.ToString();
            else
                return (attribArray[0] as DescriptionAttribute)?.Description;
        }
    }
}
