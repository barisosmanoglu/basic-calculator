using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci sayıyı giriniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplama icin 1, Çıkarma için 2, Çarpma için 3, Bölme için 4");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1 :Console.WriteLine(sayi1+sayi2);
                    break;
                case 2: Console.WriteLine(sayi1-sayi2);
                    break;
                case 3: Console.WriteLine(sayi1*sayi2);
                    break;
                case 4: Console.WriteLine(sayi1/sayi2);
                    break;
                default:
                    Console.WriteLine("Hatalı");
                    break;
            }
            Console.ReadLine();

        }
    }
}
