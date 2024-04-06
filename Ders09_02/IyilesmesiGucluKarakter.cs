using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders09_02
{
    internal class IyilesmesiGucluKarakter : Canli
    {
        public string Ad { get; set; }

        public IyilesmesiGucluKarakter(string ad)
        {
            this.Ad = ad;
        }

        public override void HasarAl()
        {
            this.Can--;
        }

        public override void Iyilestir()
        {
            this.Can += 5;
        }
    }
}
