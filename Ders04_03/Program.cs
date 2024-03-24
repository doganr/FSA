namespace Ders04_03
{
    internal class Program
    {
        static int SayiAl(string mesaj) 
        {
            Console.Write(mesaj);
            try
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                return sayi;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        static void Main()
        {
            int sayi1 = SayiAl("Birinci sayıyı giriniz:");
            int sayi2 = SayiAl("İkinci sayıyı giriniz:");

            Console.WriteLine($"{sayi1} + {sayi2} = {sayi1 + sayi2}");
        }
    }
}