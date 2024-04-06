namespace Ders09_01
{
    internal class Program
    {
        static void Main()
        {
            double toplam = Matematik.Topla(3, 10);
            Console.WriteLine(toplam);            
        }

        public void Topla(int a, int b) 
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
    }
}