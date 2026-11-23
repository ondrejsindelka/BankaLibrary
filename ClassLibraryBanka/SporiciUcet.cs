using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBanka
{
    public class SporiciUcet : Ucet
    {
        private double urokovaSazba;
        public SporiciUcet(string cislo, string majitel) : base(cislo, majitel)
        {
        }
        public SporiciUcet(string cislo, string majitel, double zustatek) : base(cislo, majitel, zustatek)
        {
        }
        public override string ToString()
        {
            return $"Sporici ucet [{VratCisloUctuCele()}, majitel: {this.majitel}, zustatek: {this.zustatek} Kc, urokova sazba: {this.urokovaSazba}%]";
        }
        public string PripsatUrok()
        {
            return "";
        }
    }
}
