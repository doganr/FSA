namespace Ders08_03
{
    internal class Program
    {
        static void Main()
        {
            Karakter k1 = new Karakter("Ryan", 100);
            Karakter k2 = new Karakter("Chun Lee", 100);

            Console.WriteLine($"Karakter1 in adı:{k1.Ad}");
            Console.WriteLine($"Karakter1 yaşıyor mu: {k1.Canlimi}");
            Console.WriteLine($"Karakter1 in canı: {k1.Can}");

            Console.WriteLine("");

            Console.WriteLine($"Karakter2 nin adı:{k2.Ad}");
            Console.WriteLine($"Karakter2 yaşıyor mu: {k2.Canlimi}");
            Console.WriteLine($"Karakter2 nin canı: {k2.Can}");

            Console.WriteLine("");
            k1.Saldir(k2);
            Console.WriteLine($"{k1.Ad} karakteri {k2.Ad} karakterine saldırıyor...");
            Console.WriteLine($"Karakter1 in canı: {k1.Can}");
            Console.WriteLine($"Karakter2 nin canı: {k2.Can}");

            Console.WriteLine("");
            k1.YardimEt(k2);
            Console.WriteLine($"{k1.Ad} karakteri {k2.Ad} karakterine yardım ediyor...");
            Console.WriteLine($"Karakter1 in canı: {k1.Can}");
            Console.WriteLine($"Karakter2 nin canı: {k2.Can}");



            //Canli canli1 = new Canli(100);
            //Console.WriteLine($"Canlı yaşıyor mu: {canli1.Canlimi}");
            //Console.WriteLine($"Canlının canı: {canli1.Can}");
            //Console.WriteLine("Canlı 1 hasar alıyor...");
            //canli1.HasarAl();
            //Console.WriteLine($"Canlının canı: {canli1.Can}");
            //Console.WriteLine("Canlı 200 hasar alıyor...");
            //canli1.HasarAl(200);
            //Console.WriteLine($"Canlının canı: {canli1.Can}");
            //Console.WriteLine($"Canlı yaşıyor mu: {canli1.Canlimi}");
        }
    }
}