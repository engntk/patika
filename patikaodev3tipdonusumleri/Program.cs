using System;

namespace patikaodev3tipdonusumleri;

class Program
{
    static void Main(string[] args)
    {
        // Implicit conversion (Bilinçsiz dönüşüm)
        // Bilinçsiz dönüşüm düşük kapasiteli bir değişkenin kendinden daha düşük kapasiteli bir değişkene atanmasıdır.

        byte a = 5;
        sbyte b = 30;
        short c = 10;
        int d = a + b + c;
        Console.WriteLine("Implicit Conversion Sonuç: " + d); // 45

        long h = d;
        Console.WriteLine("Implicit Conversion Sonuç: " + h); // 45

        float i = h;
        Console.WriteLine("Implicit Conversion Sonuç: " + i); // 45

        string e = "engin";
        char f = 't';
        object g = e + f + i;
        Console.WriteLine("Implicit Conversion Sonuç: " + g); // engint45

        // Explicit conversion (Bilinçli dönüşüm)

        Console.WriteLine("**** Explicit Conversion ****");
        int x = 4;
        byte y = (byte)x;
        Console.WriteLine("y : " + y); // 4

        int z = 100;
        byte t = (byte)z;
        Console.WriteLine("t : " + t); // 100

        float w = 10.3f;
        byte v = (byte)w;
        Console.WriteLine("v : " + v); // 10



        // ToString Methodu
        Console.WriteLine("**** ToString Methodu ****");
        int xx = 6;
        string yy = xx.ToString();
        Console.WriteLine("yy : " + yy); // 6

        string zz = 12.5f.ToString();
        Console.WriteLine("zz : " + zz);


        // System.Convert 
        Console.WriteLine("**** System.Convert ****");

        string s1 = "10", s2 = "20";
        int sayi1, sayi2;
        int Toplam;

        sayi1 = Convert.ToInt32(s1);
        sayi2 = Convert.ToInt32(s2);

        Toplam = sayi1 + sayi2;
        Console.WriteLine("Toplam : " + Toplam);


        // Parse
        Console.WriteLine("***** Parse *****");
        ParseMethod();


    }

    public static void ParseMethod()
    {
        string metin1 = "10";
        string metin2 = "10.25";
        int rakam1;
        double double1;
        // parse ederken string çıktı zorunludur.
        rakam1 = Int32.Parse(metin1);
        double1 = double.Parse(metin2);
        Console.WriteLine("rakam1 : " + rakam1);
        Console.WriteLine("double1 : " + double1);

    }


}
