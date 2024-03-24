namespace Ders04_04
{
    internal class Program
    {
        static double SayiAl(string mesaj)
        {
            Console.Write(mesaj);
            try
            {
                double sayi = Convert.ToDouble(Console.ReadLine());
                return sayi;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        static string IslemAl(string mesaj) 
        {
            Console.Write(mesaj);   
            string islem = Console.ReadLine();
            return islem;
        }

        static void Main()
        {
            double sayi1 = SayiAl("Birinci sayıyı giriniz:");
            double sayi2 = SayiAl("İkinci sayıyı giriniz:");
            string islem = IslemAl("Islemi giriniz:");

            switch(islem) 
            {
                case "+":
                    Console.WriteLine($"{sayi1} {islem} {sayi2} = {sayi1 + sayi2}");
                    break;
                case "-":
                    Console.WriteLine($"{sayi1} {islem} {sayi2} = {sayi1 - sayi2}");
                    break;
                case "*":
                    Console.WriteLine($"{sayi1} {islem} {sayi2} = {sayi1 * sayi2}");
                    break;
                case "/":
                    Console.WriteLine($"{sayi1} {islem} {sayi2} = {sayi1 / sayi2}");
                    break;
                default:
                    Console.WriteLine("Tanımlanmamış işlem girdiniz!");
                    break;
            }

        }
    }
}