using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_02
{
    internal class Log
    {
        public string Etiket {  get; set; }
        public List<string> Mesajlar { get;}

        public Log(string etiket) 
        {
            this.Etiket = etiket;
            Mesajlar = new List<string>();
        }
    }
}
