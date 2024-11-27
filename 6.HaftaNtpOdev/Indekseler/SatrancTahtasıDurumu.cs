using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Indekseler
{
//    3. Bir Satranç Tahtası Durumu
//Bir sınıf oluşturun:
// Satranç tahtasındaki her bir kareyi temsil etsin.

// Kullanıcı, indeksleyici aracılığıyla bir kareye taş koyabilsin ya da taşın ne olduğunu
//öğrenebilsin.
// Eğer kullanıcı geçersiz bir kareye erişmeye çalışırsa bir hata mesajı döndürsün.
    public class SatrancTahtasıDurumu
    {
        string[,] tahta;
        public SatrancTahtasıDurumu()
        {
            tahta = new string[8,8];
            for (int i =0;i<8;i++)
            {
                for (int j=0; j<8;j++)
                {
                    tahta[i, j] = "";
                }
            }
        }
        public string this[int satir,int sutun]
        {
            get
            {
                if (satir<0 || satir >=8 || sutun < 0 || sutun >= 8)
                {
                    throw new ArgumentException("geçersiz kare seçimi");
                }
                return tahta[satir, sutun];
            }
            set
            {
                // Geçersiz bir kareye taş koyulmaya çalışılırsa hata fırlatılır
                if (satir < 0 || satir >= 8 || sutun < 0 || sutun >= 8)
                {
                    throw new ArgumentOutOfRangeException("Geçersiz kare. Satranç tahtasında 0-7 arasındaki satır ve sütun numaralarını kullanın.");
                }

                tahta[satir, sutun] = value; // Taşı belirtilen kareye yerleştirir
            }
        }

    }
}
