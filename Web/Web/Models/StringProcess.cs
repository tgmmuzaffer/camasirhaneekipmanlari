using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public static class StringProcess
    {
        public static string ClearString(string val)
        {
            if (!string.IsNullOrEmpty(val))
            {

                //string returnText = val.ToLower();
                string[] oldValue = new string[] { "ö", "Ö", "ü", "Ü", "ç", "Ç", "İ", "ı", "Ğ", "ğ", "Ş", "ş", "-", " ", "(", ")", ";", ":", ".", "*", "\\", "/" };
                string[] newValue = new string[] { "o", "O", "u", "U", "c", "C", "I", "i", "G", "g", "S", "s", "", "", "", "", "", "", "", "", "", "" };

                for (int i = 0; i < oldValue.Length; i++)
                {
                    val = val.Replace(oldValue[i], newValue[i]);

                }

                return val;
            }
            return null;
        }
        public static string GetPath(string val)
        {
            if (!string.IsNullOrEmpty(val))
            {

                //string returnText = val.ToLower();
                string[] oldValue = new string[] { "ö", "Ö", "ü", "Ü", "ç", "Ç", "İ", "ı", "Ğ", "ğ", "Ş", "ş", " ", "(", ")", ";", ":", ".", "*", "\\", "/" };
                string[] newValue = new string[] { "o", "O", "u", "U", "c", "C", "I", "i", "G", "g", "S", "s", "-", "", "", "", "", "", "", "", "" };

                for (int i = 0; i < oldValue.Length; i++)
                {
                    val = val.Replace(oldValue[i], newValue[i]);

                }

                return val;
            }
            return null;
        }

        public static string TruncateLongString(this string str, int maxLength) =>
    str?[0..Math.Min(str.Length, maxLength)];
    }
}
