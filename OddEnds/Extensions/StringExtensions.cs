using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEnds.Extensions
{
    public static class StringExtensions
    {
        public static string AsNullIfEmpty(this string str)
        {
            return String.IsNullOrEmpty(str) ? null : str;
        }

        public static string AsNullIfWhitespace(this string str)
        {
            return String.IsNullOrWhiteSpace(str) ? null : str;
        }
    }
}
