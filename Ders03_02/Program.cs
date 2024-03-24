namespace Ders03_02
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

            Console.Write("İsminizi giriniz:");
            string isim = Console.ReadLine();

            Console.Write("Soyisminizi giriniz:");
            string soyisim = Console.ReadLine();

            Console.Write("Doğum tarihinizi giriniz:");
            string sdtarihi = Console.ReadLine();
            try 
            {
                int dtarihi = Convert.ToInt32(sdtarihi);
                Console.WriteLine($"Merhaba, {isim} {soyisim}.");
                Console.WriteLine($"Yaşınız:{2024 - dtarihi}");
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Doğum tarihi sayısal ifade olmalı!");
                Console.WriteLine("Program sonlandırılıyor...");
                Environment.Exit(0);
            }

            
        }
    }
}