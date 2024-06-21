namespace PersonelOtomasyonuApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpPersonelBilgileri = new GroupBox();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            cmbUNvan = new ComboBox();
            dtIseGirisTarihi = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            btnResimSec = new Button();
            pbResim = new PictureBox();
            txtEmail = new TextBox();
            txtTelefon = new TextBox();
            dtDogumTarihi = new DateTimePicker();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            txtTcKimlikNo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lvPersoneller = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            grpPersonelBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbResim).BeginInit();
            SuspendLayout();
            // 
            // grpPersonelBilgileri
            // 
            grpPersonelBilgileri.Controls.Add(btnSil);
            grpPersonelBilgileri.Controls.Add(btnGuncelle);
            grpPersonelBilgileri.Controls.Add(btnEkle);
            grpPersonelBilgileri.Controls.Add(cmbUNvan);
            grpPersonelBilgileri.Controls.Add(dtIseGirisTarihi);
            grpPersonelBilgileri.Controls.Add(label8);
            grpPersonelBilgileri.Controls.Add(label7);
            grpPersonelBilgileri.Controls.Add(btnResimSec);
            grpPersonelBilgileri.Controls.Add(pbResim);
            grpPersonelBilgileri.Controls.Add(txtEmail);
            grpPersonelBilgileri.Controls.Add(txtTelefon);
            grpPersonelBilgileri.Controls.Add(dtDogumTarihi);
            grpPersonelBilgileri.Controls.Add(txtSoyad);
            grpPersonelBilgileri.Controls.Add(txtAd);
            grpPersonelBilgileri.Controls.Add(txtTcKimlikNo);
            grpPersonelBilgileri.Controls.Add(label6);
            grpPersonelBilgileri.Controls.Add(label5);
            grpPersonelBilgileri.Controls.Add(label4);
            grpPersonelBilgileri.Controls.Add(label3);
            grpPersonelBilgileri.Controls.Add(label2);
            grpPersonelBilgileri.Controls.Add(label1);
            grpPersonelBilgileri.Location = new Point(12, 12);
            grpPersonelBilgileri.Name = "grpPersonelBilgileri";
            grpPersonelBilgileri.Size = new Size(952, 234);
            grpPersonelBilgileri.TabIndex = 0;
            grpPersonelBilgileri.TabStop = false;
            grpPersonelBilgileri.Text = "Personel Bİlgileri";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(712, 191);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(200, 23);
            btnSil.TabIndex = 20;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(712, 144);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(200, 23);
            btnGuncelle.TabIndex = 19;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(712, 97);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(200, 23);
            btnEkle.TabIndex = 18;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // cmbUNvan
            // 
            cmbUNvan.FormattingEnabled = true;
            cmbUNvan.Location = new Point(712, 55);
            cmbUNvan.Name = "cmbUNvan";
            cmbUNvan.Size = new Size(200, 23);
            cmbUNvan.TabIndex = 17;
            // 
            // dtIseGirisTarihi
            // 
            dtIseGirisTarihi.Location = new Point(712, 16);
            dtIseGirisTarihi.Name = "dtIseGirisTarihi";
            dtIseGirisTarihi.Size = new Size(200, 23);
            dtIseGirisTarihi.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(590, 63);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 15;
            label8.Text = "Ünvan : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(587, 24);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 14;
            label7.Text = "İşe Giriş Tarihi : ";
            // 
            // btnResimSec
            // 
            btnResimSec.Location = new Point(587, 97);
            btnResimSec.Name = "btnResimSec";
            btnResimSec.Size = new Size(97, 117);
            btnResimSec.TabIndex = 13;
            btnResimSec.Text = "RESİM SEÇ";
            btnResimSec.UseVisualStyleBackColor = true;
            btnResimSec.Click += btnResimSec_Click;
            // 
            // pbResim
            // 
            pbResim.Location = new Point(404, 21);
            pbResim.Name = "pbResim";
            pbResim.Size = new Size(154, 193);
            pbResim.TabIndex = 12;
            pbResim.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(174, 191);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 11;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(174, 157);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(200, 23);
            txtTelefon.TabIndex = 10;
            // 
            // dtDogumTarihi
            // 
            dtDogumTarihi.Location = new Point(174, 123);
            dtDogumTarihi.Name = "dtDogumTarihi";
            dtDogumTarihi.Size = new Size(200, 23);
            dtDogumTarihi.TabIndex = 9;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(174, 89);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(200, 23);
            txtSoyad.TabIndex = 8;
            txtSoyad.TextChanged += textBox3_TextChanged;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(174, 55);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(200, 23);
            txtAd.TabIndex = 7;
            // 
            // txtTcKimlikNo
            // 
            txtTcKimlikNo.Location = new Point(174, 21);
            txtTcKimlikNo.Name = "txtTcKimlikNo";
            txtTcKimlikNo.Size = new Size(200, 23);
            txtTcKimlikNo.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 199);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 5;
            label6.Text = "Email : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 165);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 4;
            label5.Text = "Telefon NUmarası";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 131);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 3;
            label4.Text = "Doğum Tarihi : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 97);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "Soyad : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 63);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Ad : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 29);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "TC Kimlik NUmarası : ";
            // 
            // lvPersoneller
            // 
            lvPersoneller.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lvPersoneller.GridLines = true;
            lvPersoneller.Location = new Point(12, 264);
            lvPersoneller.Name = "lvPersoneller";
            lvPersoneller.Size = new Size(952, 321);
            lvPersoneller.TabIndex = 1;
            lvPersoneller.UseCompatibleStateImageBehavior = false;
            lvPersoneller.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "TC Kimlik NO";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "İsim";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Doğum Tarihi";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Email";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "İşe Giriş Tarihi";
            columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Ünvan";
            columnHeader6.Width = 120;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 587);
            Controls.Add(lvPersoneller);
            Controls.Add(grpPersonelBilgileri);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpPersonelBilgileri.ResumeLayout(false);
            grpPersonelBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbResim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpPersonelBilgileri;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private TextBox txtTcKimlikNo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtTelefon;
        private DateTimePicker dtDogumTarihi;
        private Button btnResimSec;
        private PictureBox pbResim;
        private ComboBox cmbUNvan;
        private DateTimePicker dtIseGirisTarihi;
        private Label label8;
        private Label label7;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
        private ListView lvPersoneller;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}
