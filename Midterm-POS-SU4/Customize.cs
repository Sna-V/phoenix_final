using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Midterm_POS_SU4
{
    public class Customize
    {
        public static string GetDateWithSuffix(DateTime date)
        {
            int day = date.Day;
            string daySuffix = GetDaySuffix(day);
            return date.ToString($"MMM d'{daySuffix}', yyyy");
        }
        private static string GetDaySuffix(int day)
        {
            if (day >= 11 && day <= 13) return "th"; // Special case for 11th, 12th, 13th
            switch (day % 10)
            {
                case 1: return "st";
                case 2: return "nd";
                case 3: return "rd";
                default: return "th";
            }
        }
    }
}
