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
            if (valuuta == null)
                throw new ArgumentException("Valuuta peab olema määratud", "valuuta");
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

        public bool OnMääratud()
        {
            var t = !String.IsNullOrWhiteSpace(Valuuta);
            return t;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Raha);
        }

        public string Valuuta { get { return _valuuta; } set { if (value is null) _valuuta = ""; else _valuuta = value; } }

        public string Tekstina(string defaultVaartusKuiMaaramata = "", bool koosÜhikuga = true)
        {
            if (!OnMääratud())
                return defaultVaartusKuiMaaramata;

            return koosÜhikuga ? $"{Vaartus:0.00} {Valuuta}" : $"{Vaartus:0.00}";
        }

        public string ToString(bool koosÜhikuga = true)
        {
            return Tekstina("", koosÜhikuga);
        }

        public override string ToString()
        {
            return ToString(true);
        }

        public static Raha Parse(string rahaString)
        {
            if (String.IsNullOrEmpty(rahaString))
                return RahaHelper.TühiRaha;

            var components = rahaString.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            if (components.Length != 2)
                return RahaHelper.TühiRaha;

            return new Raha(decimal.Parse(components[0]), components[1]);
        }


    }
}
