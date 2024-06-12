using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryAndFileSample
{
    public partial class Form3 : Form
    {
        string fullPath  = string.Empty;
        public Form3()
        {
            InitializeComponent();
        }


        public Form3(string _path)
        {
            fullPath = _path;
            InitializeComponent();

            this.Load += LoadFilesAndFolders;
        }

        private void LoadFilesAndFolders(object? sender, EventArgs e)
        {
            string[] directories = Directory.GetDirectories(fullPath);
            string[] files = Directory.GetFiles(fullPath);

            ListDirectoryies(directories);
            ListFiles(files);
        }

        private void ListFiles(string[] files)
        {
            int index = 0;
            foreach (string file in files) 
            { 
                FileInfo fi = new FileInfo(file);

                lvFileList.Items.Add(fi.Name);
                lvFileList.Items[index].SubItems.Add((fi.Length / 1024).ToString());
                lvFileList.Items[index].SubItems.Add(((fi.Length / 1024)/1024).ToString());
                lvFileList.Items[index].SubItems.Add(fi.CreationTime.ToLongDateString());
                lvFileList.Items[index].SubItems.Add(fi.Extension);

                index++;
            }
        }

        private void ListDirectoryies(string[] directories)
        {
            //foreach (string item in directories)
            //{
            //    lstFolderList.Items.Add(item);
            //}

            lstFolderList.Items.AddRange(directories);
        }
    }
}
