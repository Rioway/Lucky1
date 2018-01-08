using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common
{
    public static class CheckInput
    {
        public static bool IsChinese(string txt)
        {
            Regex objRegex = new Regex(@"^[\u4e00 - \u9fa5]{ 0, }$");
            return objRegex.IsMatch(txt);
        }
        public static bool IsMobile(string txt)
        {
            Regex objRegex = new Regex(@"^[1]\d{11}$");
            return objRegex.IsMatch(txt);
        }
        public static bool IsNumber(string txt)
        {
            Regex objRegex = new Regex(@"^[0-9]*$");
            return objRegex.IsMatch(txt);
        }
    }
}
