using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders09_03
{
    internal class Saglikci : Karakter
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

        public Saglikci(int guc, string ad) : base(ad) 
        {          
           this.Guc = guc;
        }

        public void Iyilestir(Savasci iyilestirilecek) 
        {
            for (int i = 1; i <= Guc; i++)
                iyilestirilecek.Iyiles();
        }

        public override string ToString()
        {
            return "Sağlıkçı";
        }
    }
}
