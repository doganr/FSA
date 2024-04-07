using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_01
{
    internal class Savasci : Karakter
    {
        private int guc = 1;
        private int savunma = 1;

        public int Guc 
        {  
            get { return guc; } 
            set 
            { 
                if (guc < 1 )
                    guc = 1;
                else if (guc > 10)
                    guc = 10;
                else
                    guc = value;             
            }
        }

        public int Savunma
        {
            get { return savunma; }
            set
            {
                if (savunma < 1)
                    savunma = 1;
                else if (savunma > 10)
                    savunma = 10;
                else 
                    savunma = value;
            }
        }

        public Savasci(int guc, int savunma, string ad) : base(ad) 
        {          
            this.Guc = guc;
            this.Savunma = savunma;
        }

        public void Saldir(Savasci saldirilan) 
        {
            Console.WriteLine($"{Ad} --> {saldirilan.Ad} karakterine saldırıyor...");
            Random r = new Random();
            int saldiri = this.Guc - r.Next(Guc + 1);

            saldirilan.HasarAl(saldiri);
        }

        public void HasarAl(int saldiri)
        {
            Random r = new Random();
            int savunma = this.Savunma - r.Next(Savunma + 1);
            int azalma = (saldiri - savunma) < 0 ? 0 : saldiri - savunma;
            this.Can -= azalma;
        }

        public override string ToString() 
        {
            return "Savaşçı";
        }

        public void BilgileriYazdir() 
        {
            Console.WriteLine($"Ad:{Ad}, Can:{Can}");
        }
    }
}
