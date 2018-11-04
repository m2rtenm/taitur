using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETIS.Domain;
using ETIS.Helpers;

namespace ETIS.Extensions
{
    public static class RahaExtensions
    {
        public static bool OnMääratud(this Raha raha)
        {
            return raha != null && !raha.Equals(RahaHelper.TühiRaha);
        }

        public static bool OmabVäärtust(this Raha raha)
        {
            return OnMääratud(raha) && raha.Vaartus > 0;
        }

        public static Raha Sum(this IEnumerable<Raha> src, string valuuta = null)
        {
            var sum = new Raha(0, valuuta ?? RahaHelper.VaikeValuuta);
            foreach (var e in src)
                sum.Vaartus += e.Vaartus;


            // ..
            return sum;
        }
    }
}
