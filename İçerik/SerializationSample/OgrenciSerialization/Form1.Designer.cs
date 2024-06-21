namespace OgrenciSerialization
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
            grpOgrenciBilgileri = new GroupBox();
            rtxtOgrenciBilgileri = new RichTextBox();
            txtNotOrtalamsi = new TextBox();
            txtBolum = new TextBox();
            txtTelefon = new TextBox();
            txtEmail = new TextBox();
            dtDogumTarihi = new DateTimePicker();
            txtAdSoyad = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSerialize = new Button();
            btnDeserialize = new Button();
            grpOgrenciBilgileri.SuspendLayout();
            SuspendLayout();
            // 
            // grpOgrenciBilgileri
            // 
            grpOgrenciBilgileri.Controls.Add(rtxtOgrenciBilgileri);
            grpOgrenciBilgileri.Controls.Add(txtNotOrtalamsi);
            grpOgrenciBilgileri.Controls.Add(txtBolum);
            grpOgrenciBilgileri.Controls.Add(txtTelefon);
            grpOgrenciBilgileri.Controls.Add(txtEmail);
            grpOgrenciBilgileri.Controls.Add(dtDogumTarihi);
            grpOgrenciBilgileri.Controls.Add(txtAdSoyad);
            grpOgrenciBilgileri.Controls.Add(label7);
            grpOgrenciBilgileri.Controls.Add(label6);
            grpOgrenciBilgileri.Controls.Add(label5);
            grpOgrenciBilgileri.Controls.Add(label4);
            grpOgrenciBilgileri.Controls.Add(label3);
            grpOgrenciBilgileri.Controls.Add(label2);
            grpOgrenciBilgileri.Controls.Add(label1);
            grpOgrenciBilgileri.Location = new Point(12, 21);
            grpOgrenciBilgileri.Name = "grpOgrenciBilgileri";
            grpOgrenciBilgileri.Size = new Size(438, 376);
            grpOgrenciBilgileri.TabIndex = 0;
            grpOgrenciBilgileri.TabStop = false;
            grpOgrenciBilgileri.Text = "Öğrenci Bİlgi Ekranı";
            // 
            // rtxtOgrenciBilgileri
            // 
            rtxtOgrenciBilgileri.Location = new Point(18, 249);
            rtxtOgrenciBilgileri.Name = "rtxtOgrenciBilgileri";
            rtxtOgrenciBilgileri.Size = new Size(414, 109);
            rtxtOgrenciBilgileri.TabIndex = 13;
            rtxtOgrenciBilgileri.Text = "";
            // 
            // txtNotOrtalamsi
            // 
            txtNotOrtalamsi.Location = new Point(122, 190);
            txtNotOrtalamsi.Name = "txtNotOrtalamsi";
            txtNotOrtalamsi.Size = new Size(261, 23);
            txtNotOrtalamsi.TabIndex = 12;
            // 
            // txtBolum
            // 
            txtBolum.Location = new Point(122, 157);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(261, 23);
            txtBolum.TabIndex = 11;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(122, 124);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(261, 23);
            txtTelefon.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(122, 91);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(261, 23);
            txtEmail.TabIndex = 9;
            // 
            // dtDogumTarihi
            // 
            dtDogumTarihi.Location = new Point(122, 58);
            dtDogumTarihi.Name = "dtDogumTarihi";
            dtDogumTarihi.Size = new Size(261, 23);
            dtDogumTarihi.TabIndex = 8;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(122, 25);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(261, 23);
            txtAdSoyad.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 231);
            label7.Name = "label7";
            label7.Size = new Size(141, 15);
            label7.TabIndex = 6;
            label7.Text = "Öğrenci Hakkında Bilgiler";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 198);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 5;
            label6.Text = "Not Ortalaması : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 165);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 4;
            label5.Text = "Bölüm : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 132);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefon Numarası : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 99);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Email : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 66);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "Doğum Tarihi : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 33);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Adı Soyadı : ";
            // 
            // btnSerialize
            // 
            btnSerialize.Location = new Point(30, 417);
            btnSerialize.Name = "btnSerialize";
            btnSerialize.Size = new Size(136, 55);
            btnSerialize.TabIndex = 1;
            btnSerialize.Text = "SERIALIZE";
            btnSerialize.UseVisualStyleBackColor = true;
            btnSerialize.Click += btnSerialize_Click;
            // 
            // btnDeserialize
            // 
            btnDeserialize.Location = new Point(308, 417);
            btnDeserialize.Name = "btnDeserialize";
            btnDeserialize.Size = new Size(136, 55);
            btnDeserialize.TabIndex = 2;
            btnDeserialize.Text = "DESERIALIZE";
            btnDeserialize.UseVisualStyleBackColor = true;
            btnDeserialize.Click += btnDeserialize_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 531);
            Controls.Add(btnDeserialize);
            Controls.Add(btnSerialize);
            Controls.Add(grpOgrenciBilgileri);
            Name = "Form1";
            Text = "Form1";
            grpOgrenciBilgileri.ResumeLayout(false);
            grpOgrenciBilgileri.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpOgrenciBilgileri;
        private RichTextBox rtxtOgrenciBilgileri;
        private TextBox txtNotOrtalamsi;
        private TextBox txtBolum;
        private TextBox txtTelefon;
        private TextBox txtEmail;
        private DateTimePicker dtDogumTarihi;
        private TextBox txtAdSoyad;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSerialize;
        private Button btnDeserialize;
    }
}
