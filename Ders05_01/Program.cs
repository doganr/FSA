using System.Text.Json;

namespace Ders05_01
{
    internal class Program
    {
        static Dictionary<string, string> sozluk_dosyadan_oku(string dosya_yolu)
        {
            if (File.Exists(dosya_yolu))
            {
                string sozluk_str = File.ReadAllText(dosya_yolu);
                return JsonSerializer.Deserialize<Dictionary<string, string>>(sozluk_str);
            }
            else 
            {
                return new Dictionary<string, string>();
            }
        }

        static void sozluk_dosyaya_yaz(Dictionary<string, string> sozluk, string dosya_yolu)
        {
            string sozluk_str = JsonSerializer.Serialize(sozluk);
            File.WriteAllText(dosya_yolu, sozluk_str);
        }

        static void TrEnKelimeBul(Dictionary<string, string> sozluk) 
        {                        
            Console.Write($"Türkçe kelimeyi giriniz:");
            string tkelime = Console.ReadLine().ToLower();
            if (sozluk.Keys.Contains(tkelime))
                Console.WriteLine($"{tkelime.ToUpper()} kelimesinin İngilizce karşılığı {sozluk[tkelime].ToUpper()} dır.");
            else
                Console.WriteLine($"{tkelime.ToUpper()} kelimesi sözlükte bulunamadı.");
        }

        static void EnTrKelimeBul(Dictionary<string, string> sozluk)
        {
            Console.Write($"İngilizce kelimeyi giriniz:");
            string ekelime = Console.ReadLine().ToLower();
            if (sozluk.Keys.Contains(ekelime))
                Console.WriteLine($"{ekelime.ToUpper()} kelimesinin Türkçe karşılığı {sozluk[ekelime].ToUpper()} dır.");
            else
                Console.WriteLine($"{ekelime.ToUpper()} kelimesi sözlükte bulunamadı.");
        }

        static void TrEnKelimeEkle(Dictionary<string, string> sozluk) 
        {
            Console.Write($"Türkçe kelimeyi giriniz:");
            string tkelime = Console.ReadLine();

            Console.Write($"{tkelime} kelimesinin İngilizcesini giriniz:");
            string ekelime = Console.ReadLine();

            sozluk.Add(tkelime.ToLower(), ekelime.ToLower()); // ArAba --> ToLower --> araba

            Console.WriteLine($"{tkelime.ToUpper()} kelimesi {ekelime.ToUpper()} İngilizce karşılığı ile sözlüğe eklendi.");
        }

        static void EnTrKelimeEkle(Dictionary<string, string> sozluk)
        {
            Console.Write($"İngilizce kelimeyi giriniz:");
            string ekelime = Console.ReadLine();

            Console.Write($"{ekelime} kelimesinin Türkçesini giriniz:");
            string tkelime = Console.ReadLine();

            sozluk.Add(ekelime.ToLower(), tkelime.ToLower());

            Console.WriteLine($"{ekelime.ToUpper()} kelimesi {tkelime.ToUpper()} Türkçe karşılığı ile sözlüğe eklendi.");
        }

        static void Main()
        {
            Dictionary<string, string> tur_ing = sozluk_dosyadan_oku("tur_ing.json");
            Dictionary<string, string> ing_tur = sozluk_dosyadan_oku("ing_tur.json");

            Console.WriteLine($"|{new string('-', 80)}|");
            Console.WriteLine($"|-- {"Sözlük uygulaması v.1.0",-74} --|");

            bool devam_et = true;
            while (devam_et) 
            {
                Console.WriteLine($"|{new string('-', 80)}|");
                Console.WriteLine($"| {"Uylulamayi kapatmak için",-67} | {"x",-8} |");
                Console.WriteLine($"| {"Türkçe-İngilizce kelime arama için",-67} | {"tr",-8} |");
                Console.WriteLine($"| {"İngilizce-Türkçe kelime arama için",-67} | {"en",-8} |");
                Console.WriteLine($"| {"Türkçe-İngilizce kelime ekleme için",-67} | {"tr+",-8} |");
                Console.WriteLine($"| {"İngilizce-Türkçe kelime ekleme için",-67} | {"en+",-8} |");
                Console.WriteLine($"|{new string('-', 80)}|\n");

                Console.Write("Komutunuzu giriniz:");
                string komut = Console.ReadLine();

                switch (komut) 
                {
                    case "x":
                        devam_et = false;
                        Console.WriteLine("Uygulama sonlandırıldı!");
                        break;
                    case "tr":
                        TrEnKelimeBul(tur_ing);
                        break;
                    case "tr+":
                        TrEnKelimeEkle(tur_ing);
                        break;
                    case "en":
                        EnTrKelimeBul(ing_tur);
                        break;
                    case "en+":
                        EnTrKelimeEkle(ing_tur);
                        break;
                    default:
                        Console.WriteLine("Tanımlanmayan komut girdiniz!");
                        break;
                }                
                Console.WriteLine("");
            }


            sozluk_dosyaya_yaz(tur_ing, "tur_ing.json");
            sozluk_dosyaya_yaz(ing_tur, "ing_tur.json");
        }
    }
}