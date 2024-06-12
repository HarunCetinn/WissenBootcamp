namespace DirectoryAndFileSample
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
            btnDriveINfo = new Button();
            btnDirectoryINfo = new Button();
            btnKlasorIslemleri = new Button();
            btnKlasorKOpyala = new Button();
            btnDosyaKOpyala = new Button();
            SuspendLayout();
            // 
            // btnDriveINfo
            // 
            btnDriveINfo.AccessibleRole = AccessibleRole.TitleBar;
            btnDriveINfo.Location = new Point(12, 12);
            btnDriveINfo.Name = "btnDriveINfo";
            btnDriveINfo.Size = new Size(75, 51);
            btnDriveINfo.TabIndex = 0;
            btnDriveINfo.Text = "Sürücü Bilgileri";
            btnDriveINfo.UseVisualStyleBackColor = true;
            btnDriveINfo.Click += btnDriveINfo_Click;
            // 
            // btnDirectoryINfo
            // 
            btnDirectoryINfo.Location = new Point(115, 12);
            btnDirectoryINfo.Name = "btnDirectoryINfo";
            btnDirectoryINfo.Size = new Size(75, 51);
            btnDirectoryINfo.TabIndex = 1;
            btnDirectoryINfo.Text = "Klasör Bilgileri";
            btnDirectoryINfo.UseVisualStyleBackColor = true;
            btnDirectoryINfo.Click += btnDirectoryINfo_Click;
            // 
            // btnKlasorIslemleri
            // 
            btnKlasorIslemleri.Location = new Point(216, 12);
            btnKlasorIslemleri.Name = "btnKlasorIslemleri";
            btnKlasorIslemleri.Size = new Size(75, 51);
            btnKlasorIslemleri.TabIndex = 2;
            btnKlasorIslemleri.Text = "Klasör İşlemleri";
            btnKlasorIslemleri.UseVisualStyleBackColor = true;
            btnKlasorIslemleri.Click += btnKlasorIslemleri_Click;
            // 
            // btnKlasorKOpyala
            // 
            btnKlasorKOpyala.Location = new Point(314, 12);
            btnKlasorKOpyala.Name = "btnKlasorKOpyala";
            btnKlasorKOpyala.Size = new Size(75, 51);
            btnKlasorKOpyala.TabIndex = 3;
            btnKlasorKOpyala.Text = "KlasorKopyala";
            btnKlasorKOpyala.UseVisualStyleBackColor = true;
            btnKlasorKOpyala.Click += btnKlasorKOpyala_Click;
            // 
            // btnDosyaKOpyala
            // 
            btnDosyaKOpyala.Location = new Point(408, 12);
            btnDosyaKOpyala.Name = "btnDosyaKOpyala";
            btnDosyaKOpyala.Size = new Size(75, 51);
            btnDosyaKOpyala.TabIndex = 4;
            btnDosyaKOpyala.Text = "Dosya Kopyala";
            btnDosyaKOpyala.UseVisualStyleBackColor = true;
            btnDosyaKOpyala.Click += btnDosyaKOpyala_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDosyaKOpyala);
            Controls.Add(btnKlasorKOpyala);
            Controls.Add(btnKlasorIslemleri);
            Controls.Add(btnDirectoryINfo);
            Controls.Add(btnDriveINfo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDriveINfo;
        private Button btnDirectoryINfo;
        private Button btnKlasorIslemleri;
        private Button btnKlasorKOpyala;
        private Button btnDosyaKOpyala;
    }
}
