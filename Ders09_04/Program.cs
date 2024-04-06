namespace Ders09_04
{
    internal class Program
    {
        static void Main()
        {
            //Random r = new Random();         
            //Console.WriteLine($" Rasgele [0.0-1.0) arası double değer:{r.NextDouble()}");
            //Thread.Sleep(1000);
            //Console.WriteLine($" Rasgele [0-10) arası int değer:{r.Next(10)}");
            //Thread.Sleep(2000);
            //Console.WriteLine($" Rasgele [20-30) arası int değer:{r.Next(20,30)}");

            //karakter1, karakter2 ve karakter3 yapılacak
            //karakter1 ve karakter2 Savasci sınıfından olacak 
            //karakter3 Saglikci sınıfından olacak
            //Canli sinifi abstract
            //Karakter sinifi Canli sınıfından miras alacak
            //Savasci sınıfı Karakter sınıfından miras alacak
            //Saglikci sınıfı Karakter sınıfından miras alacak
            //---> while döngüsü ---> karakter1.Canlimi ve karakter2.Canlimi ve karakter3.Canlimi
            // rasgele bir karakter diğerine saldıracak
            // rasgele saglikci bir karakteri iyileştirecek
            // döngü sonlnana kadar
            // tüm karakterlerin canları ekrana adları ile birlikte bastırılacak...

            List<Karakter> karakterler = new List<Karakter>();
            Random r = new Random();
            Savasci karakter1 = new Savasci(4, "Can");
            Savasci karakter2 = new Savasci(10, "Güçlü");
            Saglikci karakter3 = new Saglikci(2, "Sağlam");

            karakterler.Add(karakter1);
            karakterler.Add(karakter2);
            karakterler.Add(karakter3);

            while (!OlenVarmi(karakterler)) 
            {
                int birinci = r.Next(karakterler.Count);
                int ikinci = r.Next(karakterler.Count);
                while(birinci == ikinci)
                    ikinci = r.Next(karakterler.Count);

                Karakter k1 = karakterler[birinci];
                Karakter k2 = karakterler[ikinci];

                Console.WriteLine($"K1 Tipi:{k1.ToString()}, K2 Tipi:{k2.ToString()}");
                Console.WriteLine($"K1 Adı:{k1.Ad}, K2 Adı:{k2.Ad}");
                Console.WriteLine($"K1 Sağlık:{k1.Can}, K2 Sağlık:{k2.Can}");

                if (k1.ToString() == "Sağlıkçı")
                {
                    Saglikci secili1 = (Saglikci) k1;
                    secili1.Iyilestir(k2);
                    Console.WriteLine($"{k1.Ad} karakteri {k2.Ad} karakterini iyileştiriyor...");
                }
                else 
                {
                    Savasci secili1 = (Savasci)k1;
                    secili1.Saldir(k2);
                    Console.WriteLine($"{k1.Ad} karakteri {k2.Ad} karakterine saldırıyor...");
                }

                Console.WriteLine($"K1 Tipi:{k1.ToString()}, K2 Tipi:{k2.ToString()}");
                Console.WriteLine($"K1 Adı:{k1.Ad}, K2 Adı:{k2.Ad}");
                Console.WriteLine($"K1 Sağlık:{k1.Can}, K2 Sağlık:{k2.Can}");

                Console.WriteLine("");
                Thread.Sleep(1000);
            }

        }

        static bool OlenVarmi(List<Karakter> karakterler) 
        {
            bool var = false;
            foreach (Karakter k in karakterler)
                if (!k.Canlimi) 
                {
                    var = true;
                    break;
                }  
            return var;
        }
    }
}