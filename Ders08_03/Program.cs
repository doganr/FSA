namespace Ders08_03
{
    internal class Program
    {
        static void Main()
        {
            Canli canli1 = new Canli();
            Console.WriteLine($"Canlı yaşıyor mu: {canli1.Canlimi}");
            Console.WriteLine($"Canlının canı: {canli1.Can}");
            Console.WriteLine("Canlı 1 hasar alıyor...");
            canli1.HasarAl();
            Console.WriteLine($"Canlının canı: {canli1.Can}");
            Console.WriteLine("Canlı 200 hasar alıyor...");
            canli1.HasarAl(200);
            Console.WriteLine($"Canlının canı: {canli1.Can}");
            Console.WriteLine($"Canlı yaşıyor mu: {canli1.Canlimi}");

        }
    }
}