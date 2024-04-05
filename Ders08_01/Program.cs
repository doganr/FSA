namespace Ders08_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("İlk parametre:" + args[0]);
            //Console.WriteLine("İkinci parametre:" + args[1]);
            for (int i = 0; i < args.Length; i++) 
            {
                Console.WriteLine($"{i+1}. parametrenin değeri:{args[i]}");
            }
        }
    }
}