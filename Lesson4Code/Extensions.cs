using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4Code
{
    public static class Extensions
    {
        public static bool IsMyFavoriteInt(this int val)
        {
            return val == 42;
        }


        public static string GetNewData(this IDataProvider provider, string additionalDAta)
        {
            return provider.Seed + "123" + additionalDAta;
        }
    }
}
