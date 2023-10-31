using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikdortgenNesneOlusturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen(3,4);
            Console.WriteLine("Dikdorgenin Alani = "+dikdortgen.alanHesapla());
            Console.WriteLine("Dikdorgenin Cevresi = " + dikdortgen.cevreHesapla());
        }
    }
    class Dikdortgen
    {
        private uint kisaKenar, uzunKenar;
        public Dikdortgen(uint kisaKenar, uint uzunKenar)
        {
            this.kisaKenar = kisaKenar;
            this.uzunKenar = uzunKenar;
        }
        public uint alanHesapla()
        {
            return kisaKenar  * uzunKenar;
        }
        public uint cevreHesapla()
        {
            return 2 * (kisaKenar + uzunKenar);
        }
    }
}
