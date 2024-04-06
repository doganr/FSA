using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders09_04
{
    internal abstract class Canli
    {
        private int can = 100;

        public int Can
        {
            get { return can; }
            set
            {
                if (value > 100)
                    can = 100;
                else if (value < 0)
                    can = 0;
                else
                    can = value;
            }
        }

        public bool Canlimi
        {
            get
            {
                if (Can == 0)
                    return false;
                else
                    return true;
            }
        }

        public abstract void HasarAl();
        public abstract void Iyiles();        
    }
}
