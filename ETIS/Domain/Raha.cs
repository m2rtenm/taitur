using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETIS.Domain
{
    public class Raha
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
            
        }

        public decimal? Vaartus { get; set; }
        public string _valuuta { get; set; }

        public string Valuuta { get { return _valuuta; } set { if (value is null) _valuuta = ""; else _valuuta = value; } }
    }
}
