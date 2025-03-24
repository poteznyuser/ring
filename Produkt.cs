using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Produkt
    {
        public Produkt(string nazwa, string symbol, int liczbaSztuk, double cena, string magazyn)
        {
            Nazwa = nazwa;
            Symbol = symbol;
            LiczbaSztuk = liczbaSztuk;
            Cena = cena;
            Magazyn = magazyn;
        }

        public string Nazwa { get; set; }
        public string Symbol { get; set; }
        public int LiczbaSztuk { get; set; }
        public double Cena { get; set; }
        public string Magazyn { get; set; }

            
    }
}
