using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public abstract class Bosszuallo : ISzuperhos
    {
        private double szuperero;
        private bool vanEGyengesege;

        protected Bosszuallo(double szuperero, bool vanEGyengesege)
        {
            this.szuperero = szuperero;
            this.vanEGyengesege = vanEGyengesege;
        }

        public double Szuperero { get => szuperero; set => szuperero = value; }
        public bool VanEGyengesege { get => vanEGyengesege; set => vanEGyengesege = value; }

        public bool LegyoziE(ISzuperhos szuperhos)
        {
            if (szuperhos is Bosszuallo)
            {
                Bosszuallo ellenfel = (Bosszuallo)szuperhos;
                if (vanEGyengesege && szuperero < ellenfel.szuperero)
                {
                    return true;
                } 
                if (szuperhos is Batman && szuperero * 2 >= ellenfel.szuperero)
                {
                    return true;
                }
            }
            return false;
        }

        public double MekkoraAzEreje()
        {
            return szuperero;
        }

        public abstract bool MegmentiAVilagot();

        public override string ToString()
        {
            return $"Szupererő: {szuperero}; {(vanEGyengesege? "van gyengesége" : "nincs gyengesége")}";
        }
    }
}
