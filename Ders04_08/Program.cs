using System.Text.Json;

namespace Ders04_08
{
    internal class Program
    {
        static Dictionary<string, string> sozluk_dosyadan_oku(string dosya_yolu)
        {
            string sozluk_str = File.ReadAllText(dosya_yolu);
            return JsonSerializer.Deserialize<Dictionary<string, string>>(sozluk_str);
        }

        static void sozluk_dosyaya_yaz(Dictionary<string, string> sozluk, string dosya_yolu) 
        {
            string sozluk_str = JsonSerializer.Serialize(sozluk);
            File.WriteAllText(dosya_yolu, sozluk_str);
        }

        static void Main()
        {
            Dictionary<string, string> tur_ing = sozluk_dosyadan_oku("tur_ing.json");
            Dictionary<string, string> ing_tur = sozluk_dosyadan_oku("ing_tur.json");

            Console.Write("Türkçe-İngilizce için 1, İngilizce-Türkçe için 2 giriniz:");

            if (Console.ReadLine() == "1")
            {
                Console.Write("Türkçe kelimeyi giriniz:");
                string tkelime = Console.ReadLine();
                Console.WriteLine($"{tkelime} kelimesinin İngilizce karşılığı {tur_ing[tkelime]} dır.");
            }
            else
            {
                Console.Write("İngilizce kelimeyi giriniz:");
                string ekelime = Console.ReadLine();
                Console.WriteLine($"{ekelime} kelimesinin Türkçe karşılığı {ing_tur[ekelime]} dır.");
            }

            sozluk_dosyaya_yaz(tur_ing, "tur_ing.json");
            sozluk_dosyaya_yaz(ing_tur, "ing_tur.json");
        }
    }
}