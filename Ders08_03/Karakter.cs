using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders08_03
{
    public class Karakter : Canli
    {
        public string Ad {  get; set; }

        public Karakter(string ad, int can) : base(can)
        {
            this.Ad = ad;
        }

        public void Saldir(Karakter saldirilan) 
        {
            saldirilan.HasarAl();
        }

        public void Saldir(Karakter saldirilan, int hasar_miktari) 
        {
            saldirilan.HasarAl(hasar_miktari);
        }

        public void YardimEt(Karakter yardimedilen) 
        {
            yardimedilen.Iyilestir();
        }

        public void YardimEt(Karakter yardimedilen, int iylestirme_miktari) 
        {
            yardimedilen.Iyilestir(iylestirme_miktari);        
        }
    }
}
