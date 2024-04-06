using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders09_05
{
    internal class Savasci : Karakter
    {
        private int guc = 1;

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

        public Savasci(int guc, string ad) : base(ad) 
        {          
           this.Guc = guc;
        }

        public void Saldir(Karakter saldirilan) 
        {
            for (int i = 1; i <= Guc; i++)
                saldirilan.HasarAl();
        }

        public override string ToString() 
        {
            return "Savaşçı";
        }
    }
}
