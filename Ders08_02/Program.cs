namespace Ders08_02
{
    internal class Program
    {
        static void Main()
        {
            Ogrenci ogr = new Ogrenci();
            ogr.İsim = "Ramazan";
            ogr.Soyisim = "Doğan";
            ogr.Vize = 70;
            ogr.Final = 65;
            
            Console.WriteLine("Nesnenin stringe çevrilmiş hali:\n"+ogr.ToString());
        }
    }
}