using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_01
{
    internal class Karakter : Canli
    {
        public string Ad { get; set; }

        public Karakter(string ad) 
        {
            this.Ad = ad;
        }

        public override void HasarAl()
        {
            this.Can--;
        }

        public override void Iyiles()
        {
            this.Can++;
        }
    }
}
