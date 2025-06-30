using System;

namespace patikaodev2operatorler;

class Program
{
    static void Main(string[] args)
    {
        // işlemli atama operatorleri
        // +=, -=, *=, /=, %=
        int sayi = 10;
        sayi += 5; // sayi = sayi + 5
        Console.WriteLine("Toplama işlemi sonucu: " + sayi); // "Toplama işlemi sonucu: 15"

        //Mantıksal operatorler
        // &&, ||, !

        bool isSuccess = true;
        bool isCompleted = false;

        if (isSuccess && isCompleted) // && (ve) operatoru
        {
            Console.WriteLine("Perfect!");
        }
        if (isSuccess || isCompleted) // || (veya) operatoru
        {
            Console.WriteLine("Great!");
        }
        if (isSuccess && !isCompleted) // ! (değil) operatoru
        {
            Console.WriteLine("Fine!");
        }

        // İlişkisel operatorler
        // <, >, <=, >=, ==, !=

        int a = 3;
        int b = 4;
        bool sonuc = a < b; // a, b'den küçük mü?
        Console.WriteLine("a < b: " + sonuc); // a < b: True
        sonuc = a > b; // a, b'den büyük mü?
        Console.WriteLine("a > b: " + sonuc); // a > b: False
        sonuc = a <= b; // a, b'ye küçük veya eşit mi?
        Console.WriteLine("a <= b: " + sonuc); // a <= b: True
        sonuc = a >= b; // a, b'ye büyük veya eşit mi?
        Console.WriteLine("a >= b: " + sonuc); // a >= b: False
        sonuc = a == b; // a, b'ye eşit mi?
        Console.WriteLine("a == b: " + sonuc); // a == b: False
        sonuc = a != b; // a, b'ye eşit değil mi?
        Console.WriteLine("a != b: " + sonuc); // a != b: True

        // Aritmetik operatorler
        // +, -, *, /, %

        int sayi1 = 10;
        int sayi2 = 5;
        int sonuc1 = sayi1 / sayi2;
        Console.WriteLine("Bölme işlemi sonucu: " + sonuc1); // "Bölme işlemi sonucu: 2"
        int sonuc2 = sayi1 * sayi2;
        Console.WriteLine("Çarpma işlemi sonucu: " + sonuc2); // "Çarpma işlemi sonucu: 50"
        int sonuc3 = sayi1 + sayi2;
        Console.WriteLine("Toplama işlemi sonucu: " + sonuc3); // "Toplama işlemi sonucu: 15"
        int sonuc4 = sayi1 - sayi2;
        Console.WriteLine("Çıkarma işlemi sonucu: " + sonuc4); // "Çıkarma işlemi sonucu: 5"
        int sonuc5 = sayi1 % sayi2; // Mod alma operatoru
        Console.WriteLine("Modulus işlemi sonucu: " + sonuc5); // "Mod alma işlemi sonucu: 0"



    }
}
