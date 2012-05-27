using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEnds.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> AsNullIfEmpty<T>(this IEnumerable<T> col)
        {
            return col != null && col.Any() ? col : null;
        }
    }
}
