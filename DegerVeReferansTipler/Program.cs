using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 ?? Cevap 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            // sayilar[0]=?? Cevap 999

            // int, decimal, float,double, bool --> Değer tip
            // array, class, interface --> Referans tip

            //Bellekte Stack ve Heap adında iki alan var.
            //Stack te sadece değer bilgisi tutulur. Yani sayi1=10 gibi, sayi1=sayi2 dendiğinde sayi1 i 30 a eşitler ve sayi2 ile işi olmaz.
            /*
                RefNo       Stack       RefNo       Heap
                101           sayilar1   101            [10,20,30]
                102           sayilar2    102           [100,200,300]

            *****Önemli Bilgi : Biz new etiketini kullanınca aslında stack ile heap arasında bağlantı kurmuş oluyoruz.********
            Biz sayilar1=sayilar 2 deyince sayilar1 in referans numarası değişir

            RefNo           Stack       RefNo       Heap
                102           sayilar1   101            [10,20,30]
                102           sayilar2    102           [100,200,300]
             */

        }
    }
}
