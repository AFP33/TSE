using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tse.Common
{
    public static class EnumExtenstions
    {
        public static string GetDescription(this Enum enumValue)
        {
            try
            {
                object[] attr = enumValue.GetType().GetField(enumValue.ToString())
                .GetCustomAttributes(typeof(DescriptionAttribute), false);

                return attr.Length > 0
                   ? ((DescriptionAttribute)attr[0]).Description
                   : enumValue.ToString();
            }
            catch (Exception)
            {
                return "[Not Found]";
            }
        }

        public static T ParseEnum<T>(this string stringVal)
        {
            return (T)Enum.Parse(typeof(T), stringVal);
        }
    }
}
