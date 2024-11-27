using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.HaftaNtpOdev
{
// 3. Zaman Farkını Farklı Formatlarda Hesaplama
//Bir fonksiyon yazın:
// Aynı adla ama farklı parametrelerle iki tarih arasındaki farkı hesaplasın.
// İlk sürüm, gün cinsinden farkı döndürsün.
// İkinci sürüm, saat cinsinden farkı döndürsün.
// Üçüncü sürüm, iki tarih arasında yıl, ay ve gün cinsinden farkı ayrı ayrı döndürsün.
    public class Ornek3
    {
        public double zamanfarki(DateTime tarih1,DateTime tarih2)
        {
            return (tarih2-tarih1).TotalDays;
        }
        public double zamanfarki(DateTime tarih1,DateTime tarih2,bool saatcinsinden)
        {
            return(tarih2 - tarih1).TotalHours;
        }
        public  (int Yillar, int Aylar, int Gunler) ZamanFarki(DateTime tarih1, DateTime tarih2, string format)
        {
            if (format == "yilAyGun")
            {
                // Farkı hesaplamak için iki tarihi karşılaştır
                int yilFarki = tarih2.Year - tarih1.Year;
                int ayFarki = tarih2.Month - tarih1.Month;
                int gunFarki = tarih2.Day - tarih1.Day;

                // Eğer gün farkı negatifse, ay farkından bir ay düş
                if (gunFarki < 0)
                {
                    ayFarki--;
                    gunFarki += DateTime.DaysInMonth(tarih1.Year, tarih1.Month);
                }

                // Eğer ay farkı negatifse, yıl farkından bir yıl düş
                if (ayFarki < 0)
                {
                    yilFarki--;
                    ayFarki += 12;
                }

                return (yilFarki, ayFarki, gunFarki);
            }

            throw new ArgumentException("Geçerli bir format belirtin.");
        }
    }
}
