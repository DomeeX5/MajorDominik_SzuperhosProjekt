using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try 
            { 
            Kepregeny.Szereplok("szuperhos.txt");
            Kepregeny.Szuperhosok();
            }
            catch
            {
                throw new IOException("Nem létezik a megadott fájl.");
            }
        }
    }
}
