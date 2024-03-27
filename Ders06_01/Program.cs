namespace Ders06_01
{
    internal class Program
    {
        static void Main()
        {
            Ogrenci ogrenci1 = new Ogrenci("Ramazan", "Doğan", 60, 40);
            Ogrenci ogrenci2 = new Ogrenci("Hayati", "Türe", 45, 70);            
            Ogrenci ogrenci3 = new Ogrenci("Zeynep", "Şahin", 50, 70);

            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            ogrenciler.Add(ogrenci1);
            ogrenciler.Add(ogrenci2);
            ogrenciler.Add(ogrenci3);


            Console.Write($"|   | {"İsim",-10} | {"Soyisim",-10} | {"Vize",5} "
                        + $"| {"Final",5} | {"GNotu",5} |\n");
            Console.Write("--------------------------------------------------------\n");
            for (int i = 0; i < ogrenciler.Count; i++) 
            {
                Console.Write(ogrenciler[i].BilgileriYazdir2(i + 1));
            }


            //Console.Write(ogrenci1.BilgileriYazdir2(1));
            //Console.Write(ogrenci2.BilgileriYazdir2(2));
            //Console.Write(ogrenci3.BilgileriYazdir2(3));

            //ogrenci1.BilgileriYazdir1(1);
            //ogrenci2.BilgileriYazdir1(2);
            //ogrenci3.BilgileriYazdir1(3);

            //Console.Write($"| 1 | {ogrenci1.İsim,-10} | {ogrenci1.Soyisim,-10} | {ogrenci1.Vize,5} "
            //            + $"| {ogrenci1.Final,5} | {ogrenci1.GecmeNotu,5} |\n");
            //Console.Write($"| 2 | {ogrenci2.İsim,-10} | {ogrenci2.Soyisim,-10} | {ogrenci2.Vize,5} "
            //            + $"| {ogrenci2.Final,5} | {ogrenci2.GecmeNotu,5} |\n");
            //Console.Write($"| 3 | {ogrenci3.İsim,-10} | {ogrenci3.Soyisim,-10} | {ogrenci3.Vize,5} "
            //            + $"| {ogrenci3.Final,5} | {ogrenci3.GecmeNotu,5} |\n");
        }
    }
}