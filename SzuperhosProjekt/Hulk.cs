using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    internal class Hulk : Bosszuallo, ISzuperhos
    {
        private int Rage;
        private bool Transformed;
        private int Intelligence;

        public Hulk() : base(0, true)
        {
            Rage = 0;
            Transformed = false;
            Intelligence = 100;
        }

        public bool Transforming()
        {
            if (Intelligence == 100)
            {
                Intelligence = 0;
                Rage = 100;
                if (Rage == 100)
                {
                    this.Szuperero = 1250;
                    return Transformed = true;
                }
            }
            return Transformed = false; 
        }

        public override bool LegyoziE(ISzuperhos szuperhos)
        {
            throw new NotImplementedException();
        }

        public override bool MegmentiAVilagot()
        {
            throw new NotImplementedException();
        }

        public override double MekkoraAzEreje()
        {
            throw new NotImplementedException();
        }



        // Ötletekben segített: Török Levente
    }
}
