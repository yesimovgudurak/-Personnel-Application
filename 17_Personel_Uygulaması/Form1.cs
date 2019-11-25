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
    public partial class Form1 : Form
    {
        BusinessLogicLayer BLL;
        public Form1()
        {
            InitializeComponent();
            BLL = new BusinessLogicLayer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_sistemgiris_Click(object sender, EventArgs e)
        {
            int EKS = BLL.SistemGirisKontrol(txt_kullaniciadi.Text, txt_sifre.Text);
            if(EKS>0)
            {
                AnaForm anaform = new AnaForm();
                anaform.Show();

            }
            else if(EKS==-100)
            {
                MessageBox.Show("Eksik Bilgi!!Lütfen form alanlarını doldurunuz.");
            }

        }
    }
}
