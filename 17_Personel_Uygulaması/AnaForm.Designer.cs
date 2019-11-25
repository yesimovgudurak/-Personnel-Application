namespace _17_Personel_Uygulaması
{
    partial class AnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_Personellerim = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_yenikayitekle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_emailadresi = new System.Windows.Forms.TextBox();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_yenitelefon = new System.Windows.Forms.TextBox();
            this.txt_yeniemailadresi = new System.Windows.Forms.TextBox();
            this.txt_yenisoyisim = new System.Windows.Forms.TextBox();
            this.txt_yeniisim = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_testkayitkaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_Personellerim);
            this.groupBox1.Location = new System.Drawing.Point(13, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 422);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Listesi";
            // 
            // lst_Personellerim
            // 
            this.lst_Personellerim.FormattingEnabled = true;
            this.lst_Personellerim.Location = new System.Drawing.Point(7, 20);
            this.lst_Personellerim.Name = "lst_Personellerim";
            this.lst_Personellerim.Size = new System.Drawing.Size(226, 459);
            this.lst_Personellerim.TabIndex = 0;
            this.lst_Personellerim.SelectedIndexChanged += new System.EventHandler(this.lst_Personellerim_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_yenikayitekle);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_telefon);
            this.groupBox2.Controls.Add(this.txt_emailadresi);
            this.groupBox2.Controls.Add(this.txt_soyisim);
            this.groupBox2.Controls.Add(this.txt_isim);
            this.groupBox2.Location = new System.Drawing.Point(276, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 214);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Personel Ekle";
            // 
            // btn_yenikayitekle
            // 
            this.btn_yenikayitekle.Location = new System.Drawing.Point(23, 179);
            this.btn_yenikayitekle.Name = "btn_yenikayitekle";
            this.btn_yenikayitekle.Size = new System.Drawing.Size(234, 25);
            this.btn_yenikayitekle.TabIndex = 8;
            this.btn_yenikayitekle.Text = "Kaydet";
            this.btn_yenikayitekle.UseVisualStyleBackColor = true;
            this.btn_yenikayitekle.Click += new System.EventHandler(this.btn_yenikayitekle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "TELEFON";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "EMAIL ADRESİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "SOYİSİM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "İSİM";
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(23, 153);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(234, 20);
            this.txt_telefon.TabIndex = 3;
            // 
            // txt_emailadresi
            // 
            this.txt_emailadresi.Location = new System.Drawing.Point(23, 114);
            this.txt_emailadresi.Name = "txt_emailadresi";
            this.txt_emailadresi.Size = new System.Drawing.Size(234, 20);
            this.txt_emailadresi.TabIndex = 2;
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(23, 75);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(234, 20);
            this.txt_soyisim.TabIndex = 1;
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(23, 36);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(234, 20);
            this.txt_isim.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_testkayitkaydet);
            this.groupBox3.Controls.Add(this.btn_sil);
            this.groupBox3.Controls.Add(this.btn_duzenle);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_yenitelefon);
            this.groupBox3.Controls.Add(this.txt_yeniemailadresi);
            this.groupBox3.Controls.Add(this.txt_yenisoyisim);
            this.groupBox3.Controls.Add(this.txt_yeniisim);
            this.groupBox3.Location = new System.Drawing.Point(276, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 271);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personel Düzenle / Sil";
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(142, 208);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(108, 25);
            this.btn_sil.TabIndex = 17;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Location = new System.Drawing.Point(16, 208);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(120, 24);
            this.btn_duzenle.TabIndex = 16;
            this.btn_duzenle.Text = "Düzenle";
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "TELEFON";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "EMAIL ADRESİ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "SOYİSİM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "İSİM";
            // 
            // txt_yenitelefon
            // 
            this.txt_yenitelefon.Location = new System.Drawing.Point(16, 181);
            this.txt_yenitelefon.Name = "txt_yenitelefon";
            this.txt_yenitelefon.Size = new System.Drawing.Size(234, 20);
            this.txt_yenitelefon.TabIndex = 11;
            // 
            // txt_yeniemailadresi
            // 
            this.txt_yeniemailadresi.Location = new System.Drawing.Point(16, 142);
            this.txt_yeniemailadresi.Name = "txt_yeniemailadresi";
            this.txt_yeniemailadresi.Size = new System.Drawing.Size(234, 20);
            this.txt_yeniemailadresi.TabIndex = 10;
            // 
            // txt_yenisoyisim
            // 
            this.txt_yenisoyisim.Location = new System.Drawing.Point(16, 103);
            this.txt_yenisoyisim.Name = "txt_yenisoyisim";
            this.txt_yenisoyisim.Size = new System.Drawing.Size(234, 20);
            this.txt_yenisoyisim.TabIndex = 9;
            // 
            // txt_yeniisim
            // 
            this.txt_yeniisim.Location = new System.Drawing.Point(16, 64);
            this.txt_yeniisim.Name = "txt_yeniisim";
            this.txt_yeniisim.Size = new System.Drawing.Size(234, 20);
            this.txt_yeniisim.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 455);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(225, 26);
            this.button4.TabIndex = 3;
            this.button4.Text = "JSON AL / VER";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_testkayitkaydet
            // 
            this.btn_testkayitkaydet.Location = new System.Drawing.Point(16, 239);
            this.btn_testkayitkaydet.Name = "btn_testkayitkaydet";
            this.btn_testkayitkaydet.Size = new System.Drawing.Size(234, 26);
            this.btn_testkayitkaydet.TabIndex = 18;
            this.btn_testkayitkaydet.Text = "Test Kayıtları Kaydet";
            this.btn_testkayitkaydet.UseVisualStyleBackColor = true;
            this.btn_testkayitkaydet.Click += new System.EventHandler(this.btn_testkayitkaydet_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 529);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lst_Personellerim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_emailadresi;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Button btn_yenikayitekle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_duzenle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_yenitelefon;
        private System.Windows.Forms.TextBox txt_yeniemailadresi;
        private System.Windows.Forms.TextBox txt_yenisoyisim;
        private System.Windows.Forms.TextBox txt_yeniisim;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_testkayitkaydet;
    }
}