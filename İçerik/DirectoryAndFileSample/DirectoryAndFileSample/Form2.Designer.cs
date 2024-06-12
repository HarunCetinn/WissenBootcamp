namespace DirectoryAndFileSample
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtFolderPath = new TextBox();
            btnChooseFolder = new Button();
            fbdGetFolder = new FolderBrowserDialog();
            btnGetFolderNames = new Button();
            lvFolderList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            cntMenuDetail = new ContextMenuStrip(components);
            klasörVeDosyalarToolStripMenuItem = new ToolStripMenuItem();
            cntMenuDetail.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Klasör Seç : ";
            // 
            // txtFolderPath
            // 
            txtFolderPath.Location = new Point(101, 26);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.Size = new Size(400, 23);
            txtFolderPath.TabIndex = 1;
            // 
            // btnChooseFolder
            // 
            btnChooseFolder.Location = new Point(507, 26);
            btnChooseFolder.Name = "btnChooseFolder";
            btnChooseFolder.Size = new Size(36, 23);
            btnChooseFolder.TabIndex = 2;
            btnChooseFolder.Text = "...";
            btnChooseFolder.UseVisualStyleBackColor = true;
            btnChooseFolder.Click += btnChooseFolder_Click;
            // 
            // btnGetFolderNames
            // 
            btnGetFolderNames.Location = new Point(398, 55);
            btnGetFolderNames.Name = "btnGetFolderNames";
            btnGetFolderNames.Size = new Size(103, 23);
            btnGetFolderNames.TabIndex = 3;
            btnGetFolderNames.Text = "KLasör Listesi";
            btnGetFolderNames.UseVisualStyleBackColor = true;
            btnGetFolderNames.Click += btnGetFolderNames_Click;
            // 
            // lvFolderList
            // 
            lvFolderList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvFolderList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvFolderList.ContextMenuStrip = cntMenuDetail;
            lvFolderList.FullRowSelect = true;
            lvFolderList.GridLines = true;
            lvFolderList.Location = new Point(-1, 94);
            lvFolderList.Name = "lvFolderList";
            lvFolderList.Size = new Size(693, 429);
            lvFolderList.TabIndex = 4;
            lvFolderList.UseCompatibleStateImageBehavior = false;
            lvFolderList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Sıra No";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Klasör Adı";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Klasör Yolu";
            columnHeader3.Width = 300;
            // 
            // cntMenuDetail
            // 
            cntMenuDetail.Items.AddRange(new ToolStripItem[] { klasörVeDosyalarToolStripMenuItem });
            cntMenuDetail.Name = "cntMenuDetail";
            cntMenuDetail.Size = new Size(181, 48);
            cntMenuDetail.Opening += cntMenuDetail_Opening;
            cntMenuDetail.Click += cntMenuDetail_Click;
            // 
            // klasörVeDosyalarToolStripMenuItem
            // 
            klasörVeDosyalarToolStripMenuItem.Name = "klasörVeDosyalarToolStripMenuItem";
            klasörVeDosyalarToolStripMenuItem.Size = new Size(180, 22);
            klasörVeDosyalarToolStripMenuItem.Text = "Klasör ve Dosyalar";

            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 526);
            Controls.Add(lvFolderList);
            Controls.Add(btnGetFolderNames);
            Controls.Add(btnChooseFolder);
            Controls.Add(txtFolderPath);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            cntMenuDetail.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFolderPath;
        private Button btnChooseFolder;
        private FolderBrowserDialog fbdGetFolder;
        private Button btnGetFolderNames;
        private ListView lvFolderList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ContextMenuStrip cntMenuDetail;
        private ToolStripMenuItem klasörVeDosyalarToolStripMenuItem;
    }
}