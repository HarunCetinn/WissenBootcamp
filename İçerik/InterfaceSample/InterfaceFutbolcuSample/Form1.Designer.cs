namespace InterfaceFutbolcuSample
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
            lstFutbolcular = new ListBox();
            flpFutbolcuOzellikleri = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lstFutbolcular
            // 
            lstFutbolcular.FormattingEnabled = true;
            lstFutbolcular.ItemHeight = 15;
            lstFutbolcular.Location = new Point(12, 12);
            lstFutbolcular.Name = "lstFutbolcular";
            lstFutbolcular.Size = new Size(247, 424);
            lstFutbolcular.TabIndex = 0;
            lstFutbolcular.SelectedIndexChanged += lstFutbolcular_SelectedIndexChanged;
            // 
            // flpFutbolcuOzellikleri
            // 
            flpFutbolcuOzellikleri.Location = new Point(265, 12);
            flpFutbolcuOzellikleri.Name = "flpFutbolcuOzellikleri";
            flpFutbolcuOzellikleri.Size = new Size(394, 426);
            flpFutbolcuOzellikleri.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 441);
            Controls.Add(flpFutbolcuOzellikleri);
            Controls.Add(lstFutbolcular);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstFutbolcular;
        private FlowLayoutPanel flpFutbolcuOzellikleri;
    }
}
