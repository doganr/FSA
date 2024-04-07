namespace Ders10_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Savasci s1 = new Savasci(10, 5, "Ryu");
            Savasci s2 = new Savasci(8, 7, "Ken");
            Random r = new Random();

            while (s1.Canlimi && s2.Canlimi) 
            {
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
                Thread.Sleep(2000);
            }
        }
    }
}