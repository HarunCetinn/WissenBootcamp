namespace WindowsForm
{
    partial class Form8
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
            btnButunEkle = new Button();
            SuspendLayout();
            // 
            // btnButunEkle
            // 
            btnButunEkle.Location = new Point(14, 36);
            btnButunEkle.Margin = new Padding(3, 4, 3, 4);
            btnButunEkle.Name = "btnButunEkle";
            btnButunEkle.Size = new Size(86, 31);
            btnButunEkle.TabIndex = 0;
            btnButunEkle.Text = "Buton Ekle";
            btnButunEkle.UseVisualStyleBackColor = true;
            btnButunEkle.Click += btnButunEkle_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnButunEkle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnButunEkle;
    }
}