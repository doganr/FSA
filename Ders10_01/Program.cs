namespace Ders10_01
{
    internal class Program
    {
        static void Main()
        {
            Savasci s1 = new Savasci(10, 5, "Ryu");
            Savasci s2 = new Savasci(8, 7, "Ken");            

            int dovus_suresi = 1;
            TimeSpan sure = TimeSpan.FromMinutes(dovus_suresi);
            DateTime baslangic = DateTime.Now;

            while (s1.Canlimi && s2.Canlimi) 
            {
                TimeSpan gecen_sure = DateTime.Now - baslangic;
                Console.WriteLine($"Dövüş Süresi:{dovus_suresi}dk  Geçen Süre:{gecen_sure.ToString(@"mm\:ss")}");

                RasgeleSaldir(s1, s2);

                if (gecen_sure >= sure)
                {
                    Console.WriteLine($"{dovus_suresi} dakika boyunca kazanan olmadığından oyun sonlandı!");
                    Console.WriteLine($"Kazanan: {(s1.Can>s2.Can ? s1.Ad : (s1.Can == s2.Can ? "Yok": s2.Ad))}");
                    break;
                }
                Thread.Sleep(2000);
            }
        }

        static void RasgeleSaldir(Savasci s1, Savasci s2) 
        {
            Random r = new Random();

            s1.BilgileriYazdir();
            s2.BilgileriYazdir();
            if (r.Next(1, 3) == 1)
            {
                s1.Saldir(s2);
            }
            else
            {
                s2.Saldir(s1);
            }
            s1.BilgileriYazdir();
            s2.BilgileriYazdir();
            Console.WriteLine("");
        }
    }
}