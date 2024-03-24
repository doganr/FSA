namespace Ders04_01
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Kaç adet sayı gireceksiniz:");
            int adet = Convert.ToInt32(Console.ReadLine());

            double[] sayilar = new double[adet];

            int indeks = 0;

            while (indeks<adet) 
            {
                Console.Write($"{indeks + 1}. sayıyı giriniz:");
                sayilar[indeks] = Convert.ToDouble(Console.ReadLine());
                indeks++;
            }

            double toplam = 0;
            indeks = 0;
            while (indeks < adet) 
            {
                toplam += sayilar[indeks]; // toplam = toplam + sayilar[indeks];
                indeks++;
            }

            double ortalama = toplam / adet;

            Console.WriteLine($"Girilen {adet} adet sayının ortalaması {ortalama} dır.");
        }
    }
}