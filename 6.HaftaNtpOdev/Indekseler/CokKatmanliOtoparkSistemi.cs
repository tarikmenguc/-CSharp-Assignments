using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Indekseler
{
//    Çok Katmanlı Bir Otopark Sistemi
//Bir sınıf oluşturun:
// Her katmanda bir dizi park yerini temsil etsin.
// Kullanıcı, indeksleyici aracılığıyla belirli bir kat ve park yeri kombinasyonuna
//erişebilsin.
// Park yeri boşsa &quot; Empty&quot; döndürsün, doluysa araç plakasını göstersin.
    public class CokKatmanliOtoparkSistemi
    {
        string[,] parkyerleri;
        public CokKatmanliOtoparkSistemi(int katsayisi , int parkyerisayisi)
        {
            parkyerleri = new string[katsayisi,parkyerisayisi];
            for (int i = 0; i < katsayisi; i++)
            {
                for (int j = 0; j < parkyerisayisi; j++)
                {
                    parkyerleri[i, j] = "Empty";
                }
            }
        }
        public string this[int kat,int parkyeri]
        {
            get
            {
                if (kat<0 || kat> parkyerleri.GetLength(0) || parkyeri <0 || parkyeri >= parkyerleri.GetLength(1))
                {
                    throw new ArgumentException("uygun kat ve park yeri giriniz");
                }
                return parkyerleri[kat,parkyeri];
            }
            set
            {
                if (kat < 0 || kat > parkyerleri.GetLength(0) || parkyeri < 0 || parkyeri >= parkyerleri.GetLength(1))
                {
                    throw new ArgumentException("uygun kat ve park yeri giriniz");
                }
                parkyerleri[kat,parkyeri] = value;
            }

        }
        
    }
}
