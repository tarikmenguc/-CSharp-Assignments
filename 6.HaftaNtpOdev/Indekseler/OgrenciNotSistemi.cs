using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indekseler
{
//    2. Bir Öğrenci Not Sistemi
//Bir sınıf oluşturun:
// Öğrencilerin aldığı derslerin notlarını depolasın.
// Kullanıcı indeksleyici aracılığıyla ders adına göre notlara erişebilsin.
// Eğer ders yoksa bir hata mesajı döndürsün.
    public class OgrenciNotSistemi
    {
        Dictionary<string, int> repo = new Dictionary<string, int>();

      public int this[string dersadi]
        {
            get
            {
                if (repo.ContainsKey(dersadi))
                {
                    return repo[dersadi];
                }
                else
                {
                    throw new KeyNotFoundException("böyle bir ders yok");
                }
            }
            set
            {
                repo[dersadi] = value;
            }

        }
        public void dersekle(string dersadi,int notu)
        {
            repo[dersadi] = notu;
        }

    }
}
