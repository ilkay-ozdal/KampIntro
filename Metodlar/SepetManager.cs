using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //naming convention -  yazım kuralları
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi : "+urun.Adi);
        }

        public void Ekle2(string Adi, string Aciklama, double fiyat)
        {
            Console.WriteLine("Adi : "+Adi+"Aciklama : "+Aciklama + "Fiyatı : " + fiyat);
        }
    }
}
