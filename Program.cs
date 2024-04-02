using System;
using System.Globalization;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sayı Tahmin
            // 1-100 arasında rastgele tutulan bir sayıyı buldurmaya çalışın.
            // Puanlama yapınız.
            // devam etmek istiyorsa devam etsin...

            do
            {
                int tutulan = (new Random()).Next(1, 100);
                int hak = 5;
                int tur = 0;
                int sayi;

                double sorupuani = 100 / hak;

                while (hak > 0)
                {
                    tur++;
                    Console.Write($"{tur}.sayı: ");
                    sayi = int.Parse(Console.ReadLine());
                    hak--;

                    if (sayi == tutulan)
                    {
                        double puan = 100 - (sorupuani * (tur - 1));
                        Console.WriteLine($"Tebrikler {tur} defada bildiniz.");
                        Console.WriteLine($"Toplam puan: {puan}");
                        break;
                    }
                    else
                    {
                        if (hak == 0)
                            break;

                        if (tutulan > sayi)
                            Console.WriteLine("yukarı");
                        else
                            Console.WriteLine("aşağı");
                    }
                }
                Console.WriteLine("oyun bitti");

                Console.Write("devam etmek istiyormusunuz? (e/h): ");
                string result = Console.ReadLine();

                if (result=="h" || result =="hayır")
                    break;

            } while (true);

        }
    }
}
