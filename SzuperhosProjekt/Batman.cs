﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Batman : ISzuperhos, IMilliardos
    {
        private double lelemenyesseg;

        public Batman()
        {
            this.lelemenyesseg = 100;
        }

        public void KutyutKeszit()
        {
            lelemenyesseg += 50;
        }

        public bool LegyoziE(ISzuperhos szuperhos)
        {
            if (szuperhos is Bosszuallo)
            {
                Bosszuallo ellenfel = (Bosszuallo)szuperhos;
                if (lelemenyesseg >= ellenfel.Szuperero)
                {
                    return true;
                }
            }
            return false;
        }

        public double MekkoraAzEreje()
        {
            return lelemenyesseg*2;
        }


        public override string ToString()
        {
            return $"Batman: leleményesség: {lelemenyesseg}";
        }
    }
}