using System.Drawing;

namespace Ders03_03
{
    internal class Program
    {
        static void Main()
        {
            //Adınızı giriniz: Ramazan Özgür
            //Soyadınızı giriniz: Doğan
            //Vize notunuzu giriniz: 50
            //Final notunuzu giriniz: 60
            //------------------------------
            //Merhaba, Ramazan Özgür Doğan
            //Vize notunuz: 50, Final notunuz: 60
            //Geçme notunuz 56 olarak hesaplanmıştır.

            Console.Write("Adınızı giriniz:");
            string ad = Console.ReadLine();
            Console.Write("Soyadınızı giriniz:");
            string soyad = Console.ReadLine();
            Console.Write("Vize notunuzu giriniz:");
            string svize = Console.ReadLine();
            Console.Write("Final notunuzu giriniz:");
            string sfinal = Console.ReadLine();

            try 
            {
                double vize = Convert.ToDouble(svize);
                double final = Convert.ToDouble(sfinal);
                Console.WriteLine($"Merhaba, {ad} {soyad}");
                Console.WriteLine($"Vize notunuz: {vize}, Final notunuz: {final}");
                Console.WriteLine($"Geçme notunuz {vize * 0.4 + final * 0.6} olarak hesaplanmıştır.");
            }
            catch 
            {
                Console.WriteLine("Girilen vize ve final değerlerini işlerken hata ile karşılaşıldı!");
                Console.WriteLine("Uygulama sonlandırılıyor...");
                Environment.Exit(0);
            }
        }
    }
}