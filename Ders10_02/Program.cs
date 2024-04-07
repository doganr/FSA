using System.Text.Json;

namespace Ders10_02
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
            //List<Log> kayitlar = new List<Log>();
            Loglayici kayitlar = new Loglayici($"Log_{baslangic.ToString(@"dd.MM.yyyy_hh.mm.ss")}.json");

            while (s1.Canlimi && s2.Canlimi)
            {
                TimeSpan gecen_sure = DateTime.Now - baslangic;
                Log kayit = new Log(gecen_sure.ToString(@"mm\:ss"));

                Console.WriteLine($"Dövüş Süresi:{dovus_suresi}dk  Geçen Süre:{gecen_sure.ToString(@"mm\:ss")}");
                kayit.Mesajlar.Add(s1.BilgileriGonder());
                kayit.Mesajlar.Add(s2.BilgileriGonder());
                kayit.Mesajlar.Add(RasgeleSaldir(s1, s2));
                kayit.Mesajlar.Add(s1.BilgileriGonder());
                kayit.Mesajlar.Add(s2.BilgileriGonder());
                //kayitlar.Add(kayit);
                kayitlar.Logs.Add(kayit);

                if (gecen_sure >= sure)
                {
                    Console.WriteLine($"{dovus_suresi} dakika boyunca kazanan olmadığından oyun sonlandı!");
                    Console.WriteLine($"Kazanan: {(s1.Can > s2.Can ? s1.Ad : (s1.Can == s2.Can ? "Yok" : s2.Ad))}");
                    break;
                }
                Thread.Sleep(1000);
            }

            kayitlar.SaveToFile();
            //string yazilacak = JsonSerializer.Serialize(kayitlar);
            //File.WriteAllText($"Log_{baslangic.ToString(@"dd.MM.yyyy_hh.mm.ss")}.json", yazilacak);
        }

        static string RasgeleSaldir(Savasci s1, Savasci s2)
        {
            string mesaj;
            Random r = new Random();

            s1.BilgileriYazdir();
            s2.BilgileriYazdir();
            if (r.Next(1, 3) == 1)
            {
                mesaj = s1.Saldir(s2);
            }
            else
            {
                mesaj = s2.Saldir(s1);
            }
            s1.BilgileriYazdir();
            s2.BilgileriYazdir();
            Console.WriteLine("");

            return mesaj;
        }
    }
}