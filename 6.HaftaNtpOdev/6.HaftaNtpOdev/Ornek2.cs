using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.HaftaNtpOdev
{
//    2. Farklı Şekillerin Alanını Hesaplayan Bir Fonksiyon
//Bir fonksiyon yazın:
// Aynı adla ama farklı parametrelerle farklı şekillerin alanını hesaplasın.
// İlk sürüm, bir karenin alanını hesaplasın(bir kenar uzunluğu verilerek).
// İkinci sürüm, bir dikdörtgenin alanını hesaplasın(iki kenar uzunluğu verilerek).
// Üçüncü sürüm, bir dairenin alanını hesaplasın(yarıçap verilerek).
    public class Ornek2
    {
        public double sekil(int karekenar)
        {

            return karekenar*4;
        }
        public double sekil(int kısa,int uzun)
        {
            return kısa * uzun;
        }
        public double sekil(int r,bool iscircle)
        {
            if (iscircle)
            {
                return Math.PI * r * r;
            }
            else
            {
                throw new ArgumentException("bu parametre sadece daie ile çalışır");
            }
          
        }


    }
}
