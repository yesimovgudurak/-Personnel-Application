using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_Personel_Uygulaması
{
    public partial class AnaForm : Form
    {
        BusinessLogicLayer BLL;
        public AnaForm()
        {
            InitializeComponent();
            BLL = new BusinessLogicLayer();
        }

        private void btn_yenikayitekle_Click(object sender, EventArgs e)
        {
            int EKS = BLL.Personel_YeniKayit(Guid.NewGuid(), txt_isim.Text, txt_soyisim.Text, txt_emailadresi.Text, txt_telefon.Text);

            if(EKS>0)
            {
                PersonelDoldur();//kayıt eklediğimiz zaman yan tarafa liste gelecek
            }
            else if(EKS==-100)
            {
                MessageBox.Show("Lütfen isim ve soyisim alanlarını doldurunuz.");
            }
            else
            {
                MessageBox.Show("Değer eklenmedi.Sistem Yöneticiniz ile görüşünüz.");
            }
        }
        private void PersonelDoldur()
        {
            List<Personel> PersonelListesi = BLL.Personel_Tum_Liste();//bll de dödürülen listeyi başa listeye atıyoruz
            lst_Personellerim.DataSource = PersonelListesi;

            //lst_Personellerim.DataSource=BLL.Personel_Tum_Liste();


        }

        private void AnaForm_Load(object sender, EventArgs e)//ana formu yüklerken ne yapayım
        {
            PersonelDoldur();
        }

        private void lst_Personellerim_SelectedIndexChanged(object sender, EventArgs e)//LİST BOXDA Bİ ŞEY SEÇERSEK
        {
            ListBox Lst = (ListBox)sender;//ben sana bir parametre vericem tipi object
            Personel LstPersonel = (Personel)Lst.SelectedItem;
            Personel DatabasePersonel = BLL.Personel_Kayit_Getir(LstPersonel.PersonelID);
            if(DatabasePersonel !=null)
            {
                txt_yeniisim.Text = DatabasePersonel.Isim;
                txt_yenisoyisim.Text = DatabasePersonel.Soyisim;
                txt_yeniemailadresi.Text = DatabasePersonel.EmailAdres;
                txt_yenitelefon.Text = DatabasePersonel.Telefon;
            }

        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            Guid PersonelID = ((Personel)lst_Personellerim.SelectedItem).PersonelID;
            int EKS = BLL.Personel_Kayit_Guncelle(PersonelID, txt_yeniisim.Text, txt_yenisoyisim.Text, txt_yeniemailadresi.Text, txt_yenitelefon.Text);
            if(EKS>0)
            {
                PersonelDoldur();
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi yapılmadı.");
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Kaydı silmek istediğinize emin misiniz?","Bilgilendirme",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if(Res==DialogResult.OK)
            {
                Personel P1 = (Personel)lst_Personellerim.SelectedItem;
                int EKS = BLL.Personel_Sil(P1.PersonelID);
                if(EKS>0)
                {
                    PersonelDoldur();
                }
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi");
            }

        }

        private void btn_testkayitkaydet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                BLL.Personel_YeniKayit(Guid.NewGuid(), FakeData.NameData.GetFirstName(), FakeData.NameData.GetSurname(),FakeData.NameData.GetFullName()+"@abc.com", FakeData.PhoneNumberData.GetPhoneNumber());
            }
            PersonelDoldur();
        }
    }
}
