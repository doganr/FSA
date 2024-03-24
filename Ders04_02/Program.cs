namespace Ders04_02
{
    internal class Program
    {
        static void Topla1(int sayi1, int sayi2) 
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine($"{sayi1} + {sayi2} = {toplam}");
        }

        static void Topla1(double sayi1, double sayi2)
        {
            double toplam = sayi1 + sayi2;
            Console.WriteLine($"{sayi1} + {sayi2} = {toplam}");
        }

        static int Topla2(int sayi1, int sayi2) 
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        static double Topla2(double sayi1, double sayi2)
        {
            double toplam = sayi1 + sayi2;
            return toplam;
        }

        static void Main()
        {
            Topla1(3, 5);
            Topla1(12, 20);

            int t = Topla2(7, 3);
            Console.WriteLine($"7 + 3 = {t}");
        }
    }
}