using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Personel_Uygulaması
{
    public class BusinessLogicLayer
    {
        DataAccessLayer DAL;
        SqlDataReader reader;

        public BusinessLogicLayer()
        {
            DAL = new DataAccessLayer();
        }

        public int SistemGirisKontrol(string kullaniciAdi, string sifre)
        {
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre))
            {
                //SistemKullanici s = new SistemKullanici();
                //s.KullaniciAdi = kullaniciAdi;
                //s.Sifre = sifre;
                //return DAL.SistemGirisKontrol(s);

                return DAL.SistemGirisKontrol(new SistemKullanici()
                {
                    KullaniciAdi = kullaniciAdi,
                    Sifre = sifre
                });
            }
            else
            {
                return -100;//eksik bilgi
            }


        }
        public int Personel_YeniKayit(Guid PersonelID, string Isim, string Soyisim, string EmailAdres, string TelefonNumarasi)

        {
            if (PersonelID != Guid.Empty && !string.IsNullOrEmpty(Isim) && !string.IsNullOrEmpty(Soyisim))
            {
                Personel P1 = new Personel();
                P1.PersonelID = PersonelID;
                P1.Isim = Isim;
                P1.Soyisim = Soyisim;
                P1.EmailAdres = EmailAdres;
                P1.Telefon = TelefonNumarasi;

                return DAL.Personel_YeniKayit(P1);
            }
            else
            {
                return -100;//eksik bilgi
            }
        }
        internal List<Personel> Personel_Tum_Liste()
        {
            List<Personel> Personellerim = new List<Personel>();
            try
            {
                reader = DAL.PersonelTumListe();
                while (reader.Read())
                {
                    Personellerim.Add(new Personel()
                    {
                        PersonelID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        Isim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        Soyisim = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        EmailAdres = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        Telefon = reader.IsDBNull(3) ? string.Empty : reader.GetString(4)
                    });
                }
                reader.Close();
            }
            catch (Exception)
            {

                //log
            }
            finally
            {
                DAL.BaglantiAyarla();
            }
            return Personellerim;
        }

        internal Personel Personel_Kayit_Getir(Guid ID)
        {
            Personel P = new Personel();
            try
            {
                reader = DAL.Personel_Kayit_Getir(ID);
                while (reader.Read())
                {

                    {
                        P.PersonelID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0);
                        P.Isim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                        P.Soyisim = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                        P.EmailAdres = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                        P.Telefon = reader.IsDBNull(3) ? string.Empty : reader.GetString(4);
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {

                //log
            }
            finally
            {
                DAL.BaglantiAyarla();
            }
            return P;
        }
        public int Personel_Kayit_Guncelle(Guid PersonelID, string Isim, string Soyisim, string EmailAdres, string TelefonNumarasi)

        {

            Personel P1 = new Personel()
            {
                PersonelID = PersonelID,
                Isim = Isim,
                Soyisim = Soyisim,
                EmailAdres = EmailAdres,
                Telefon = TelefonNumarasi
            };
            return DAL.Personel_Kayit_Guncelle(P1);
        }
        internal int Personel_Sil(Guid ID)
        {
            return DAL.Personel_Sil(ID);
        }
    }
}
