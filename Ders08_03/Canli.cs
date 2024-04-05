using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders08_03
{
    public class Canli
    {
        private int can = 100;

        public int Can 
        {
            get { return can; }
            set 
            {
                if (value>100)
                    can = 100;
                else if (value<0)
                    can = 0;
                else
                    can = value; 
            }
        }

        public bool Canlimi 
        {
            get 
            { 
                if(Can == 0)
                    return false;
                else
                    return true;                    
            }
        }

        public void HasarAl() 
        {
            Can--;
        }

        public void HasarAl(int hasar_miktari) 
        {
            Can -= hasar_miktari;
        }

        public void Iyilestir() 
        {
            Can++;
        }

        public void Iyilestir(int iyilesme_miktari) 
        {
            Can += iyilesme_miktari;
        }
    }
}
