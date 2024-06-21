using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassSample
{
    public static class ExtensionMethod
    {
        public static string ClearString(this string param)
        {
            param = param.ToLower()
                .Replace("ş", "s")
                .Replace("ğ", "g")
                .Replace("ç", "c")
                .Replace("ü", "u")
                .Replace("ı", "i")
                .Replace("ö", "o")
                .Replace("   ", " ")
                .Replace("  ", " ");
                

            return CultureInfo.CurrentUICulture.TextInfo.ToTitleCase(param);//string ifadedeki kelimelerin ilk harflerini büyük harfe çevirir
        }
    }
}
