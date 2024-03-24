using System.Drawing;

namespace Ders02_02
{
    internal class Program
    {
        static void Main()
        {

            //|   | İsim    | Soyisim | Vize | Final | G.Notu |
            //---------------------------------------------------
            //| 1 | Ramazan | Doğan   |   60 |    70 |     66 |
            //| 2 | Ahmet   | Şahin   |   50 |    50 |     50 |
            //| 3 | Zeynep  | Türe    |   40 |    60 |     52 |

            string ogr1_isim = "Ramazan";
            string ogr1_soyisim = "Doğan";
            double ogr1_vize = 60;
            double ogr1_final = 70;

            string ogr2_isim = "Ahmet";
            string ogr2_soyisim = "Şahin";
            double ogr2_vize = 50;
            double ogr2_final = 50;

            string ogr3_isim = "Zeynep";
            string ogr3_soyisim = "Türe";
            double ogr3_vize = 40;
            double ogr3_final = 60;

            Console.Write($"|   | {"İsim",-10} | {"Soyisim",-10} | {"Vize", 5} | {"Final",5} | {"GNotu",5} |\n");
            Console.Write("--------------------------------------------------------\n");
            Console.Write($"| 1 | {ogr1_isim,-10} | {ogr1_soyisim,-10} | {ogr1_vize,5} | {ogr1_final,5} | {(ogr1_vize * 0.4 + ogr1_final * 0.6),5} |\n");
            Console.Write($"| 2 | {ogr2_isim,-10} | {ogr2_soyisim,-10} | {ogr2_vize,5} | {ogr2_final,5} | {(ogr2_vize * 0.4 + ogr2_final * 0.6),5} |\n");
            Console.Write($"| 3 | {ogr3_isim,-10} | {ogr3_soyisim,-10} | {ogr3_vize,5} | {ogr3_final,5} | {(ogr3_vize * 0.4 + ogr3_final * 0.6),5} |\n");





            ////Öğrenci adı: **isim**, Öğrenci soyadı: **soyisim**
            ////Vize notu: **vize**
            ////Final notu: **final**
            ////Gecme notu: **vize%40+final%60**

            //string isim = "Ramazan Özgür";
            //string soyisim = "Doğan";
            //double vize = 70.0;
            //double final = 50;

            //Console.Write($"Öğrenci adı: {isim}, Öğrenci soyadı: {soyisim}\n");
            //Console.Write($"Vize notu: {vize}\n");
            //Console.Write($"Final notu: {final}\n");
            //Console.Write($"Gecme notu: {vize * 0.4 + final * 0.6}");














            //int dogum_tarihi = 1987;
            //string isim = "Ramazan Özgür";
            //string soyisim = "Doğan";

            //Console.Write($"Hoş geldiniz, {isim} {soyisim}.\n");
            //Console.Write($"Yaşınız:{(2024 - dogum_tarihi)}");

            //Console.Write(String.Format("Hoş geldiniz, {0} {1}.\n",isim,soyisim));
            //Console.Write(String.Format("Yaşınız:{0}", (2024 - dogum_tarihi)));

            //Console.WriteLine("Hoş geldiniz, " + isim + " " + soyisim + ".");
            //Console.WriteLine("Yaşınız:" + (2024 - dogum_tarihi));

            //Console.Write("Hoş geldiniz, ");
            //Console.Write(isim);
            //Console.Write(" ");
            //Console.Write(soyisim);
            //Console.Write(".\n");

            //Console.Write("Yaşınız:");
            //Console.Write(2024 - dogum_tarihi);

        }
    }
}