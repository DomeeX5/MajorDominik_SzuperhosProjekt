using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public static class Kepregeny
    {
        public static List<ISzuperhos> szuperhosok = new List<ISzuperhos>();
        public static void Szereplok(string faljnev)
        {
            using (var fileReader = new StreamReader(faljnev))
            {
                string[] darabol;
                while (!fileReader.EndOfStream)
                {
                    darabol = fileReader.ReadLine().Split(' ');
                }
            }
        }
        public static void Szuperhosok()
        {

        }
    }
}
