using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBanka
{
    public class Ucet
    {
        public static readonly int KODBANKY=1234;
        protected string cislo;
        protected string majitel;
        protected double zustatek;

        public Ucet(string cislo, string majitel, double zustatek)
        {
            this.cislo = cislo;
            this.majitel = majitel;
            this.zustatek = zustatek;
        }
        public Ucet(string cislo, string majitel)
        {
            this.cislo = cislo;
            this.majitel = majitel;
            this.zustatek = 0;
        }
        public string Vlozit(double vkladanaCastka)
        {
            this.zustatek += vkladanaCastka;

            return $"Vlozeno: {vkladanaCastka} \nnovy zustatek: {this.zustatek}";
        }
        public virtual string Vybrat(double vybranaCastka)
        {
            if (this.zustatek>=vybranaCastka)
            {
                return "Tolik penez vybrat nemuzete";
            }
            else
            {
                this.zustatek -= vybranaCastka;
                //return "Vybrano: " + vybranaCastka + " \nnovy zustatek: " + this.zustatek;
                return $"Vybrano: {vybranaCastka} \nnovy zustatek: {this.zustatek}";
            }
        }
        public virtual string PripsatUrok()
        {
            return "Urok lze pripsat pouze na sporicim uctu";
        }
        protected string VratCisloUctuCele()
        {
            return $"{this.cislo}/{KODBANKY}";
        }
        public override string ToString()
        {
            return $"Ucet [{VratCisloUctuCele()}, majitel: {this.majitel}, zustatek: {this.zustatek} Kc]";
        }
    }
}
