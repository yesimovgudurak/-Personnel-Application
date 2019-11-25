using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Personel_Uygulaması
{
   public class DataAccessLayer
    {
        SqlConnection connect;
        SqlCommand command;
        SqlDataReader reader;
        int Sonuc = 0;

        public DataAccessLayer()
        {
            connect = new SqlConnection();
            connect.ConnectionString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
        }

        public void BaglantiAyarla()
        {
            if(connect.State==System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }
            else
            {
                connect.Close();
            }
        }
        public int SistemGirisKontrol(SistemKullanici K)
        {
            try
            {
                command = new SqlCommand("sp_SistemKullanici_Kontrol", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar).Value = K.KullaniciAdi;
                command.Parameters.Add("@Sifre", SqlDbType.NVarChar).Value = K.Sifre;
                BaglantiAyarla();
                Sonuc = (int)command.ExecuteScalar();

            }
            catch (Exception)
            {

          
            }

            finally
            {
                BaglantiAyarla();
            }
            return Sonuc;
        }
        public int Personel_YeniKayit(Personel P)
        {
            try
            {
                command = new SqlCommand("sp_Personel_Ekle", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@PersonelID", SqlDbType.UniqueIdentifier).Value = P.PersonelID;
                command.Parameters.Add("@Isim", SqlDbType.NVarChar).Value = P.Isim;
                command.Parameters.Add("@Soyisim", SqlDbType.NVarChar).Value = P.Soyisim;
                command.Parameters.Add("EmailAdres", SqlDbType.NVarChar).Value = P.EmailAdres;
                command.Parameters.Add("@TelefonNumarasi", SqlDbType.NVarChar).Value = P.Telefon;
                BaglantiAyarla();
                Sonuc = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

              
            }
            finally
            {
                BaglantiAyarla();
            }
            return Sonuc;
        }//her yaptığımız kayıt formdaki liste gitsin

        internal SqlDataReader PersonelTumListe()
        {
            command = new SqlCommand("sp_Personel_Getir", connect);
            command.CommandType = CommandType.StoredProcedure;
            BaglantiAyarla();
            return command.ExecuteReader();

        }
        internal SqlDataReader Personel_Kayit_Getir(Guid ID)
        {
            command = new SqlCommand("sp_PersonelID_Getir", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@PersonelID", SqlDbType.UniqueIdentifier).Value = ID;
            BaglantiAyarla();
            return command.ExecuteReader();     

        }

        internal int Personel_Kayit_Guncelle(Personel P)
        {
            try
            {
                command = new SqlCommand("sp_Personel_Duzenle", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@PersonelID", SqlDbType.UniqueIdentifier).Value = P.PersonelID;
                command.Parameters.Add("@Isim", SqlDbType.NVarChar).Value = P.Isim;
                command.Parameters.Add("@Soyisim", SqlDbType.NVarChar).Value = P.Soyisim;
                command.Parameters.Add("EmailAdres", SqlDbType.NVarChar).Value = P.EmailAdres;
                command.Parameters.Add("@TelefonNumarasi", SqlDbType.NVarChar).Value = P.Telefon;
                BaglantiAyarla();
                Sonuc = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

      //log
            }

            finally
            {
                BaglantiAyarla();
            }
            return Sonuc;
        }

        internal int Personel_Sil(Guid ID)
        {
            try
            {
                command = new SqlCommand("sp_Personel_Sil", connect);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@PersonelID", SqlDbType.UniqueIdentifier).Value = ID;
                BaglantiAyarla();
                Sonuc = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

               
            }
            finally
            {
                BaglantiAyarla();
            }
            return Sonuc;
        }
        }

    }

  

