namespace Ders09_03
{
    internal class Program
    {
        static void Main()
        {
            //karakter1, karakter2 ve karakter3 yapılacak
            //karakter1 ve karakter2 Savasci sınıfından olacak 
            //karakter3 Saglikci sınıfından olacak
            //Canli sinifi abstract
            //Karakter sinifi Canli sınıfından miras alacak
            //Savasci sınıfı Karakter sınıfından miras alacak
            //Saglikci sınıfı Karakter sınıfından miras alacak

            Savasci karakter1 = new Savasci(4, "Can");
            Savasci karakter2 = new Savasci(10, "Güçlü");
            Saglikci karakter3 = new Saglikci(2, "Sağlam");

            Console.WriteLine($"(karakter1) Adı:{karakter1.Ad} " +
                              $"Gücü:{karakter1.Guc} " +
                              $"Tipi:{karakter1.ToString()} " +
                              $"Sağlığı:{karakter1.Can}");

            Console.WriteLine($"(karakter2) Adı:{karakter2.Ad} " +
                              $"Gücü:{karakter2.Guc} " +
                              $"Tipi:{karakter2.ToString()} " +
                              $"Sağlığı:{karakter2.Can}");

            Console.WriteLine($"(karakter3) Adı:{karakter3.Ad} " +
                              $"Gücü:{karakter3.Guc} " +
                              $"Tipi:{karakter3.ToString()} " +
                              $"Sağlığı:{karakter3.Can}");

            Console.WriteLine("");
            Console.WriteLine($"{karakter1.Ad} karakteri {karakter2.Ad} karakterine saldırıyor");
            karakter1.Saldir(karakter2);

            Console.WriteLine("");
            Console.WriteLine($"(karakter1) Adı:{karakter1.Ad} " +
                              $"Gücü:{karakter1.Guc} " +
                              $"Tipi:{karakter1.ToString()} " +
                              $"Sağlığı:{karakter1.Can}");

            Console.WriteLine($"(karakter2) Adı:{karakter2.Ad} " +
                              $"Gücü:{karakter2.Guc} " +
                              $"Tipi:{karakter2.ToString()} " +
                              $"Sağlığı:{karakter2.Can}");

            Console.WriteLine($"(karakter3) Adı:{karakter3.Ad} " +
                              $"Gücü:{karakter3.Guc} " +
                              $"Tipi:{karakter3.ToString()} " +
                              $"Sağlığı:{karakter3.Can}");

            Console.WriteLine("");
            Console.WriteLine($"{karakter2.Ad} karakteri {karakter1.Ad} karakterine 2 kez saldırıyor");
            karakter2.Saldir(karakter1);
            karakter2.Saldir(karakter1);

            Console.WriteLine("");
            Console.WriteLine($"(karakter1) Adı:{karakter1.Ad} " +
                              $"Gücü:{karakter1.Guc} " +
                              $"Tipi:{karakter1.ToString()} " +
                              $"Sağlığı:{karakter1.Can}");

            Console.WriteLine($"(karakter2) Adı:{karakter2.Ad} " +
                              $"Gücü:{karakter2.Guc} " +
                              $"Tipi:{karakter2.ToString()} " +
                              $"Sağlığı:{karakter2.Can}");

            Console.WriteLine($"(karakter3) Adı:{karakter3.Ad} " +
                              $"Gücü:{karakter3.Guc} " +
                              $"Tipi:{karakter3.ToString()} " +
                              $"Sağlığı:{karakter3.Can}");

            Console.WriteLine("");
            Console.WriteLine($"{karakter3.Ad} karakteri {karakter1.Ad} karakterini 3 kez iyileştiriyor");
            karakter3.Iyilestir(karakter1);
            karakter3.Iyilestir(karakter1);
            karakter3.Iyilestir(karakter1);

            Console.WriteLine("");
            Console.WriteLine($"(karakter1) Adı:{karakter1.Ad} " +
                              $"Gücü:{karakter1.Guc} " +
                              $"Tipi:{karakter1.ToString()} " +
                              $"Sağlığı:{karakter1.Can}");

            Console.WriteLine($"(karakter2) Adı:{karakter2.Ad} " +
                              $"Gücü:{karakter2.Guc} " +
                              $"Tipi:{karakter2.ToString()} " +
                              $"Sağlığı:{karakter2.Can}");

            Console.WriteLine($"(karakter3) Adı:{karakter3.Ad} " +
                              $"Gücü:{karakter3.Guc} " +
                              $"Tipi:{karakter3.ToString()} " +
                              $"Sağlığı:{karakter3.Can}");
        }
    }
}