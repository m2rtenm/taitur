using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETIS.Helpers;

namespace ETIS.Domain
{
    public class Raha : IEquatable<Raha>
    {
        public Raha()
        {
            Vaartus = 0;
            Valuuta = "";
        }

        public Raha(decimal? vaartus, string valuuta)
        {
            Vaartus = Math.Round(vaartus ?? 0, 2);
            Valuuta = valuuta;
        }

        public Raha(Raha raha)
        {
            Vaartus = raha.Vaartus;
            Valuuta = raha.Valuuta;
        }

        public decimal? Vaartus { get; set; }
        public string _valuuta { get; set; }

        public bool Equals(Raha other)
        {
            if (other == null)
                return false;

            return Vaartus == other.Vaartus && String.Compare(Valuuta, other.Valuuta, StringComparison.InvariantCultureIgnoreCase) == 0;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Raha);
        }

        public string Valuuta { get { return _valuuta; } set { if (value is null) _valuuta = ""; else _valuuta = value; } }
    }
}
