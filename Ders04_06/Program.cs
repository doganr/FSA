namespace Ders04_06
{
    internal class Program
    {
        static string MetinAl(string mesaj)
        {
            Console.Write(mesaj);
            string metin = Console.ReadLine();
            return metin;
        }

        static double SayiAl(string mesaj)
        {
            Console.Write(mesaj);
            double sayi = Convert.ToDouble(Console.ReadLine());
            return sayi;
        }

        static bool OgrenciEklenecekmi() 
        {
            Console.Write("Yeni öğrenci eklenecek mi( Evet:e, Hayır:h):");
            bool eklenecek = false;
            if (Console.ReadLine() == "e")
                eklenecek = true;
            return eklenecek;
        }

        static void Main()
        {
            List<string> isimler = new List<string>();
            List<string> soyisimler = new List<string>();
            List<double> vizeler = new List<double>();
            List<double> finaller = new List<double>();

            while (OgrenciEklenecekmi()) 
            {
                isimler.Add(MetinAl($"{isimler.Count + 1}. öğrencinin adı:"));
                soyisimler.Add(MetinAl($"{soyisimler.Count + 1}. öğrencinin soyadı:"));
                vizeler.Add(SayiAl($"{vizeler.Count + 1}. öğrencinin vize notu:"));
                finaller.Add(SayiAl($"{finaller.Count + 1}. öğrencinin final notu:"));
                Console.Write("\n");
            }


            Console.Write("\n");
            Console.Write($"|   | {"İsim",-10} | {"Soyisim",-10} | {"Vize",5} "
                        + $"| {"Final",5} | {"GNotu",5} |\n");
            Console.Write("--------------------------------------------------------\n");

            for (int i = 0; i < isimler.Count; i++)
            {
                Console.Write($"| {i + 1} | {isimler[i],-10} | {soyisimler[i],-10} | {vizeler[i],5} "
                            + $"| {finaller[i],5} | {(vizeler[i] * 0.4 + finaller[i] * 0.6),5} |\n");
            }

        }
    }
}