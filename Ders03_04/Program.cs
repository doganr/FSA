namespace Ders03_04
{
    internal class Program
    {
        static void Main()
        {
            // Birinci sayıyı giriniz: 10
            // İkinci sayıyı giriniz: 20
            // İşlemi giriniz: +
            // -------------------------
            // 10 + 20 = 30

            // Birinci sayıyı giriniz: 10
            // İkinci sayıyı giriniz: 20
            // İşlemi giriniz: -
            // -------------------------
            // 10 - 20 = -10

            // Birinci sayıyı giriniz: 10
            // İkinci sayıyı giriniz: 2
            // İşlemi giriniz: *
            // -------------------------
            // 10 * 2 = 20

            // Birinci sayıyı giriniz: 10
            // İkinci sayıyı giriniz: 2
            // İşlemi giriniz: /
            // -------------------------
            // 10 / 2 = 5

            Console.Write("Birinci sayıyı giriniz:");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz:");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İşlemi giriniz:");
            string islem = Console.ReadLine();

            Console.WriteLine("-------------------------");

            switch (islem)
            {
                case "+":
                    Console.Write($"{sayi1} {islem} {sayi2} = {sayi1 + sayi2}");
                    break;
                case "-":
                    Console.Write($"{sayi1} {islem} {sayi2} = {sayi1 - sayi2}");
                    break;
                case "*":
                    Console.Write($"{sayi1} {islem} {sayi2} = {sayi1 * sayi2}");
                    break;
                case "/":
                    Console.Write($"{sayi1} {islem} {sayi2} = {sayi1 / sayi2}");
                    break;
                default:
                    Console.Write("Tanımlı olmayan işlem girdiniz!");
                    break;
            }

            //if (islem == "+")
            //    Console.Write($"{sayi1} {islem} {sayi2} = {sayi1 + sayi2}");
            //else if (islem == "-")
            //    Console.Write($"{sayi1} {islem} {sayi2} = {sayi1 - sayi2}");
            //else if (islem == "*")
            //    Console.Write($"{sayi1} {islem} {sayi2} = {sayi1 * sayi2}");
            //else if (islem == "/")
            //    Console.Write($"{sayi1} {islem} {sayi2} = {sayi1 / sayi2}");
            //else
            //    Console.Write("Tanımlı olmayan işlem girdiniz!");



            //#################################################


            //Console.Write("Adınızı giriniz:");
            //string isim = Console.ReadLine();

            //Console.Write("Soyadınızı giriniz:");
            //string soyisim = Console.ReadLine();

            //Console.Write("Vize notunu giriniz:");
            //double vize = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Final notunu giriniz:");
            //double final = Convert.ToDouble(Console.ReadLine());

            //if (final < 45)
            //    Console.WriteLine("Geçme notunuz 0 dır, dersten kaldınız!");
            //else if((vize*0.4+final*0.6)<45)
            //    Console.WriteLine($"Geçme notunuz {vize*0.4+final*0.6} dır, dersten kaldınız!");
            //else
            //    Console.WriteLine($"Geçme notunuz {vize * 0.4 + final * 0.6} dır, dersi geçtiniz!");


            // Adınızı giriniz: Ramazan Özgür
            // Soyadınızı giriniz: Doğan
            // Vize notunu giriniz: 80
            // Final notunu giriniz: 40
            // -----------------------------------
            // Merhaba, Ramazan Özgür DOĞAN
            // Geçme notunuz 0 dır, dersten kaldınız!


            // Adınızı giriniz: Ramazan Özgür
            // Soyadınızı giriniz: Doğan
            // Vize notunu giriniz: 80
            // Final notunu giriniz: 60
            // -----------------------------------
            // Merhaba, Ramazan Özgür DOĞAN
            // Geçme notunuz 68 dır, dersi geçtiniz!

            // Adınızı giriniz: Ramazan Özgür
            // Soyadınızı giriniz: Doğan
            // Vize notunu giriniz: 30
            // Final notunu giriniz: 50
            // -----------------------------------
            // Merhaba, Ramazan Özgür DOĞAN
            // Geçme notunuz 42 dır, dersten kaldınız!

            // şartlar --->
            // final < 45 ise gnotu = 0 
            // vize*0.4 + final*0.6 < 45 ise gnotu=0






            // true && true = true
            // true && false = false
            // false && true = false
            // false && false = false

            // true || true = true
            // true || false = true
            // false || true = true
            // false || false = false

            // a < b     --> a b den küçükse true değilse false
            // a <= b    --> a b ye eşit yada küçükse true değilse false
            // a > b     --> a b den büyükse true değilse false
            // a >= b    --> a b ye eşit yada küçükse true değilse false
            // a == b    --> a b ye eşitse true değilse false
            // !true = false, !false = true

            //Console.Write("Hava sıcaklığını giriniz:");
            //int sicaklik = Convert.ToInt32(Console.ReadLine());

            //if (sicaklik < 5)
            //    Console.WriteLine("Hava soğuk");
            //else if (sicaklik >= 5 && sicaklik <= 20)
            //    Console.WriteLine("Hava ılık");
            //else
            //    Console.WriteLine("Hava sıcak");
        }
    }
}