namespace Ders09_05
{
    internal class Program
    {
        static void Main()
        {
            List<Karakter> karakterler = new List<Karakter>();
            Random r = new Random();
            while (KarakterEklenecekMi()) 
                karakterler.Add(KarakterOlustur());

            Console.WriteLine("");
            Console.WriteLine("");

            while (!OlenVarmi(karakterler))
            {
                int birinci = r.Next(karakterler.Count);
                int ikinci = r.Next(karakterler.Count);
                while (birinci == ikinci)
                    ikinci = r.Next(karakterler.Count);

                Karakter k1 = karakterler[birinci];
                Karakter k2 = karakterler[ikinci];

                KarakterlerinBilgileriniYazdir(karakterler);

                if (k1.ToString() == "Sağlıkçı")
                {
                    Saglikci secili1 = (Saglikci)k1;
                    secili1.Iyilestir(k2);
                    Console.WriteLine($"{k1.Ad} karakteri {k2.Ad} karakterini iyileştiriyor...");
                }
                else
                {
                    Savasci secili1 = (Savasci)k1;
                    secili1.Saldir(k2);
                    Console.WriteLine($"{k1.Ad} karakteri {k2.Ad} karakterine saldırıyor...");
                }

                KarakterlerinBilgileriniYazdir(karakterler);

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

        static bool KarakterEklenecekMi() 
        {
            Console.Write(new String('#', 100) + "\n");
            Console.Write("Yeni karakter eklenecek mi(e:Evet,h:Hayır):");
            if(Console.ReadLine()=="e")
                return true;
            else 
                return false;
        }

        static Karakter KarakterOlustur() 
        {
            Console.Write(new String('-', 100) + "\n");
            Console.Write("Karakter tipini giriniz (1:Sağlıkçı, 2:Savaşçı):");
            if (Console.ReadLine() == "1")
            {
                Console.Write("Karakterin adını giriniz:");
                string ad = Console.ReadLine();
                Console.Write("Karakterin gücünü giriniz:");
                int güc = Convert.ToInt32(Console.ReadLine());

                Saglikci karakter = new Saglikci(güc, ad);
                return karakter;
            }
            else 
            {
                Console.Write("Karakterin adını giriniz:");
                string ad = Console.ReadLine();
                Console.Write("Karakterin gücünü giriniz:");
                int güc = Convert.ToInt32(Console.ReadLine());

                Savasci karakter = new Savasci(güc, ad);
                return karakter;
            }

        }

        static void KarakterlerinBilgileriniYazdir(List<Karakter> karakterler) 
        {
            foreach (Karakter k in karakterler)
                Console.Write($"Ad:{k.Ad,-20}, Tip:{k.ToString(),-10}, Can:{k.Can,4}\n");
        }
    }
}