using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Ders08_02
{
    public class Ogrenci
    {
        private string isim = "";
        private string soyisim = "";
        private double vize = 0;
        private double final = 0;

        public string İsim
        {
            get { return isim.ToUpper(); }
            set { isim = value.ToLower(); }
        }

        public string Soyisim
        {
            get { return soyisim.ToUpper(); }
            set { soyisim = value.ToLower(); }
        }

        public double Vize
        {
            get { return vize; }
            set
            {
                if (value < 0)
                    vize = 0;
                else if (value > 100)
                    vize = 100;
                else
                    vize = value;
            }
        }

        public double Final
        {
            get { return final; }
            set
            {
                if (value < 0)
                    final = 0;
                else if (value > 100)
                    final = 100;
                else
                    final = value;
            }
        }

        public double GecmeNotu 
        {
            get 
            {
                if (final < 45)
                    return 0;
                else
                    return vize * 0.4 + final * 0.6;
            }
        }

        public Ogrenci()
        { 
        
        }

        public Ogrenci(string isim, string soyisim)
        {
            this.İsim = isim;
            this.Soyisim = soyisim;
        }

        public Ogrenci(string isim, string soyisim, double vize, double final)
        {
            this.İsim = isim;
            this.Soyisim = soyisim;
            this.Vize = vize;
            this.Final = final;
        }

        public void BilgileriYazdir1(int satir_no) 
        {
            Console.Write($"| {satir_no} | {this.İsim,-10} | {this.Soyisim,-10} | {this.Vize,5} "
                        + $"| {this.Final,5} | {this.GecmeNotu,5} |\n");
        }

        public string BilgileriYazdir2(int satir_no) 
        {
            return $"| {satir_no} | {this.İsim,-10} | {this.Soyisim,-10} | {this.Vize,5} "
                 + $"| {this.Final,5} | {this.GecmeNotu,5} |\n";
        }

        public override string ToString()
        {
            return $"İsim: {this.İsim,-10}\n" +
                   $"Soyisim: {this.Soyisim,-10}\n" +
                   $"Vize Notu: {this.Vize,5}\n" +
                   $"Final Notu: {this.Final,5}\n" +
                   $"Geçme Notu: {this.GecmeNotu,5}\n";
            //return $"| {this.İsim,-10} | {this.Soyisim,-10} | {this.Vize,5} "
            //     + $"| {this.Final,5} | {this.GecmeNotu,5} |\n";
            //return base.ToString();
        }
    }
}
