using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Personel_Uygulaması
{
   public class Personel
    {
        public Guid PersonelID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string EmailAdres { get; set; }
        public string Telefon { get; set; }

        public override string ToString()//
        {
            return $"{Isim} {Soyisim}";
        }
    }
    //Bu propertyler personeller tablosundaki sütunlardır.
   
}
