﻿namespace WindowsForm
{
    partial class Form2
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
            txtMetin = new TextBox();
            lblMetin = new Label();
            SuspendLayout();
            // 
            // txtMetin
            // 
            txtMetin.Location = new Point(76, 43);
            txtMetin.Name = "txtMetin";
            txtMetin.Size = new Size(257, 23);
            txtMetin.TabIndex = 0;
            txtMetin.TextChanged += txtMetin_TextChanged;
            txtMetin.MouseEnter += txtMetin_MouseEnter;
            txtMetin.MouseLeave += txtMetin_MouseLeave;
            // 
            // lblMetin
            // 
            lblMetin.AutoSize = true;
            lblMetin.Location = new Point(76, 89);
            lblMetin.Name = "lblMetin";
            lblMetin.Size = new Size(38, 15);
            lblMetin.TabIndex = 1;
            lblMetin.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 284);
            Controls.Add(lblMetin);
            Controls.Add(txtMetin);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMetin;
        private Label lblMetin;
    }
}