using System;
using System.Text.Json;

namespace Ders04_07
{
    internal class Program
    {
        static void Main()
        {
            //Dictionary<string,string> tur_ing = new Dictionary<string,string>();
            //tur_ing.Add("araba", "car");
            //tur_ing.Add("top", "ball");
            //tur_ing.Add("masa", "table");

            //Dictionary<string, string> ing_tur = new Dictionary<string, string>();
            //ing_tur.Add("car", "araba");
            //ing_tur.Add("ball", "top");
            //ing_tur.Add("table", "masa");

            string tur_ing_str = File.ReadAllText("tur_ing.json");
            Dictionary<string, string> tur_ing = JsonSerializer.Deserialize<Dictionary<string, string>>(tur_ing_str);

            string ing_tur_str = File.ReadAllText("ing_tur.json");
            Dictionary<string, string> ing_tur = JsonSerializer.Deserialize<Dictionary<string, string>>(ing_tur_str);

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

            tur_ing_str = JsonSerializer.Serialize(tur_ing);
            File.WriteAllText("tur_ing.json", tur_ing_str);

            ing_tur_str = JsonSerializer.Serialize(ing_tur);
            File.WriteAllText("ing_tur.json", ing_tur_str);
        }
    }
}