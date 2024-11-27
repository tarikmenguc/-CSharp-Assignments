using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indekseler
{
    /*
     * Bir sınıf oluşturun:
 Sınıf, bir kitap koleksiyonunu (dizi) depolasın.
 Kullanıcı, indeksleyici aracılığıyla belirli 
  bir indekste hangi kitabın olduğunu
öğrenebilsin ve kitap adını değiştirebilsin.
 Eğer kullanıcı geçersiz bir indeks ile erişim yaparsa 
  uygun bir hata mesajı döndürsün.
     */
    public class KitaplıkYonetimSistemi
    {
        int[] data = new int[5];
        public int this[int index]
        {

            get { return data[index]; }
            set
            {
                if (index < 0 || index > data.Length)
                {
                    throw new ArgumentOutOfRangeException("hatalı index girişi");
                }
                data[index] = value;
             }
        }
    }
}
