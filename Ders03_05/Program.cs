namespace Ders03_05
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Kaç adet sayının ortalaması hesaplanacak:");
            int adet = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[adet];

            for (int i = 0; i < adet; i++) 
            {
                Console.Write($"{i}. sayıyı giriniz:");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            int toplam = 0;
            for (int i = 0; i < adet; i++)
            {
                toplam = toplam + sayilar[i];
            }

            double ortalama = toplam / adet;

            Console.WriteLine($"Girilen sayıların ortalaması={ortalama}");


                //for (int i = 1; i <= 10; i+=5) // i++ --> i = i + 1 | i+=2 --> i = i+2 
                //    Console.WriteLine(i);

                //for (int i = 10; i >= 0; i-=2)
                //    Console.WriteLine(i);

                //Console.WriteLine(1);
                //Console.WriteLine(2);
                //Console.WriteLine(3);
                //Console.WriteLine(4);
                //Console.WriteLine(5);
            }
    }
}