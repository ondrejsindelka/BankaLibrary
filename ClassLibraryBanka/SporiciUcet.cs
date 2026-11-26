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
        public SporiciUcet(string cislo, string majitel, double urokovaSazba) : base(cislo, majitel)
        {
            this.urokovaSazba = urokovaSazba;
        }
        public SporiciUcet(string cislo, string majitel, double zustatek, double urokovaSazba) : base(cislo, majitel, zustatek)
        {
            this.urokovaSazba = urokovaSazba;
        }
        public override string ToString()
        {
            return $"Sporici ucet [{VratCisloUctuCele()}, majitel: {this.majitel}, zustatek: {this.zustatek} Kc, urokova sazba: {this.urokovaSazba}%]";
        }

        public override string PripsatUrok()
        {
            double pripsanyUrok = this.zustatek * (urokovaSazba / 100);
            this.zustatek += pripsanyUrok;
            return $"Pripsan urok: {pripsanyUrok} \nnovy zustatek: {this.zustatek}";
        }
    }
}
