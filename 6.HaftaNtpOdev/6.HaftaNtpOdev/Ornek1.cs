using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.HaftaNtpOdev
{
//1. Matematiksel İşlemleri Çeşitlendiren Bir Fonksiyon

//Bir fonksiyon yazın:
// Aynı adla ama farklı parametrelerle toplam işlemi yapacak.
// İlk sürümü iki tam sayıyı toplasın.
// İkinci sürümü üç tam sayıyı toplasın.
// Üçüncü sürümü bir dizi (array) tam sayıyı toplasın.
    public class Ornek1
    {
        int[] dizi = new int[3];
       public int topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int topla(int sayi1, int sayi2,int sayi3)
        {
            return sayi1 + sayi2+ sayi3;
        }
         public int topla(int[] sayilar)
        {
            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }
            return toplam;
        }
    }
}
