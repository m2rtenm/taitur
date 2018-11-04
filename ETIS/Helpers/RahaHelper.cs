using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETIS.Domain;

namespace ETIS.Helpers
{
    public static class RahaHelper
    {
        public const string VaikeValuuta = "EUR";

        public static Raha AnnaRaha(decimal väärtus, KLVaartus valuuta)
        {
            return new Raha(väärtus, ValuutaKood(valuuta));
        }

        public static Raha TühiRaha
        {
            get { return new Raha(); }
        }

        public static string ValuutaKood(KLVaartus valuuta)
        {
            var vaartusTrimmed = valuuta.Vaartus.Trim();
            return vaartusTrimmed.Substring(0, 3).ToUpper();
        }
    }
}
