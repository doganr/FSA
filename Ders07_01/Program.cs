namespace Ders07_01
{
    internal class Program
    {
        static bool OgrenciEklenecekMi() 
        {
            Console.Write("Yeni öğrenci eklemek istiyor musunuz? (e) Evet, (h) Hayır:");
            string sonuc = Console.ReadLine();
            if(sonuc == "e")
                return true;
            else
                return false;
        }

        static void Main()
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            while(OgrenciEklenecekMi())
            {
                Console.Write("--------------------------------------------------------\n");
                Console.Write("Öğrenci adını giriniz:");
                string isim = Console.ReadLine();
                Console.Write("Öğrenci soyadını giriniz:");
                string soyisim = Console.ReadLine();
                Console.Write("Vize notunu giriniz:");
                double vize = Convert.ToDouble(Console.ReadLine());
                Console.Write("Final notunu giriniz:");
                double final = Convert.ToDouble(Console.ReadLine());

                Ogrenci ogr = new Ogrenci(isim, soyisim, vize, final);
                ogrenciler.Add(ogr);
                Console.Write("--------------------------------------------------------\n");
            }

            Console.WriteLine("\n\n");
            Console.Write($"|   | {"İsim",-10} | {"Soyisim",-10} | {"Vize",5} "
                        + $"| {"Final",5} | {"GNotu",5} |\n");
            Console.Write("--------------------------------------------------------\n");
            for (int i = 0; i < ogrenciler.Count; i++)
            {
                Console.Write(ogrenciler[i].BilgileriYazdir2(i + 1));
            }
        }
    }
}