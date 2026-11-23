using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBanka
{
    public class KontokorentniUcet : Ucet
    {
        private double limit;
        

        public KontokorentniUcet(string cislo, string majitel, double zustatek, double limit) : base(cislo, majitel, zustatek)
        {
            this.limit = limit;
        }
        public KontokorentniUcet(string cislo, string majitel, double limit) : base(cislo, majitel)
        {
            this.limit = limit;
        }
        public override string Vybrat(double vybranaCastka)
        {
            if((zustatek - vybranaCastka )>= -this.limit)
            {
                //LIMIT napr 500
                //vybrat 1500, zustatek byl 1000, bude -500, coz je >=-500
                this.zustatek -= vybranaCastka;
                return $"Vybrano: {vybranaCastka} \nnovy zustatek: {this.zustatek}";
            }


            return "Nelze vybrat. Byl prekrocen povoleny kontokorentni limit";
        }
        public override string ToString()
        {
            return $"Kontokorentni ucet [{VratCisloUctuCele()}, majitel: {this.majitel}, zustatek: {this.zustatek} Kc, limit: {this.limit}]";
        }
    }
}
