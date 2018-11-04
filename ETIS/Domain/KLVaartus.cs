using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETIS.Domain
{
    public class KLVaartus
    {
        public long? ObjektId { get; set; }
        public string Kirjeldus { get; set; }
        public string Nimi { get; set; }
        public string Vaartus { get; set; }
    }
}
