namespace Ders09_02
{
    internal class Program
    {
        static void Main()
        {
            // Canli c = new Canli(); sınıf abstract olduğu için nesne üretilemez

            Karakter normalk = new Karakter("Normal");
            IyilesmesiGucluKarakter gucluk = new IyilesmesiGucluKarakter("Güçlü");

            Console.WriteLine($"normalk nin adı:{normalk.Ad}");
            Console.WriteLine($"Karakter1 yaşıyor mu: {normalk.Canlimi}");
            Console.WriteLine($"Karakter1 in canı: {normalk.Can}");

            Console.WriteLine("");

            Console.WriteLine($"gucluk nin adı:{gucluk.Ad}");
            Console.WriteLine($"gucluk yaşıyor mu: {gucluk.Canlimi}");
            Console.WriteLine($"gucluk nin canı: {gucluk.Can}");

            Console.WriteLine("");
            normalk.HasarAl();
            normalk.HasarAl();
            normalk.HasarAl();
            normalk.HasarAl();
            normalk.HasarAl();
            gucluk.HasarAl();
            gucluk.HasarAl();
            gucluk.HasarAl();

            Console.WriteLine("normalk 5 kere gucluk 3 kere hasar aldı..");

            Console.WriteLine("");

            Console.WriteLine($"normalk nin adı:{normalk.Ad}");
            Console.WriteLine($"Karakter1 yaşıyor mu: {normalk.Canlimi}");
            Console.WriteLine($"Karakter1 in canı: {normalk.Can}");

            Console.WriteLine("");

            Console.WriteLine($"gucluk nin adı:{gucluk.Ad}");
            Console.WriteLine($"gucluk yaşıyor mu: {gucluk.Canlimi}");
            Console.WriteLine($"gucluk nin canı: {gucluk.Can}");

            Console.WriteLine("");

            Console.WriteLine("normalk 1 kere gucluk 1 kere iyileşiyor...");
            normalk.Iyilestir();
            gucluk.Iyilestir();

            Console.WriteLine("");

            Console.WriteLine($"normalk nin adı:{normalk.Ad}");
            Console.WriteLine($"Karakter1 yaşıyor mu: {normalk.Canlimi}");
            Console.WriteLine($"Karakter1 in canı: {normalk.Can}");

            Console.WriteLine("");

            Console.WriteLine($"gucluk nin adı:{gucluk.Ad}");
            Console.WriteLine($"gucluk yaşıyor mu: {gucluk.Canlimi}");
            Console.WriteLine($"gucluk nin canı: {gucluk.Can}");
        }
    }
}