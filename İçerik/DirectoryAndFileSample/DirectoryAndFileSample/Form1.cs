namespace DirectoryAndFileSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDriveINfo_Click(object sender, EventArgs e)
        {
            //Disk üzerindeki Sürücü bilgilerini almak için kullanýlan sýnýf DriveINfo sýnýfý. 
            DriveInfo di = new DriveInfo("C:\\");
            string driveInfo = string.Empty;
            driveInfo = $"Sürücü Adý : {di.Name}\n" +
                $"Sürücü Ön Adý : {di.VolumeLabel}\n" +
                $"Toplam Boyut : {di.TotalSize}\n" +
                $"Boþ Alan Boyutu : {di.TotalFreeSpace}\n" +
                $"Kullanýlabilir Boþ Alan : {di.AvailableFreeSpace}";

            MessageBox.Show(driveInfo);
        }

        private void btnDirectoryINfo_Click(object sender, EventArgs e)
        {
            //Bir kalsörün bilgileirni iþletim sisteminden alabilmek için kullanýlan sýnýf DirectoryInfo sýnýfýdýr
            DirectoryInfo dirInfo = new DirectoryInfo("C:\\UygulamaIcerikleri");
            string directoryInfo = string.Empty;
            directoryInfo = $"Klasör Yolu : {dirInfo.FullName}\n" +
                $"Klasör Adý : {dirInfo.Name}\n" +
                $"Bir Üst Klasör Adý : {dirInfo.Parent}\n" +
                $"Dosya Türü : {dirInfo.Attributes}\n" +
                $"Oluþturulma Tarihi : {dirInfo.CreationTime.ToString("yyyy-MM-dd HH:mm:ss")}\n" +
                $"Son Deðiþitirlme Tarihi : {dirInfo.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss")}";

            MessageBox.Show(directoryInfo);
        }

        private void btnKlasorIslemleri_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("C:\\NewDirectory"))
                Directory.Delete("C:\\NewDirectory");
            Directory.CreateDirectory("C:\\NewDirectory");
        }

        private void btnKlasorKOpyala_Click(object sender, EventArgs e)
        {
            string sourceDir = "C:\\UygulamaIcerikleri";
            string destinationDir = "C:\\NewDirectory\\MoveFolder";
            Directory.Move(sourceDir, destinationDir);
        }

        private void btnDosyaKOpyala_Click(object sender, EventArgs e)
        {
            string sourceFile = "C:\\NewDirectory\\MoveFolder\\Kisiler.txt";
            string destinationFile = "C:\\NewDirectory\\NewKisiler.txt";

            File.Move(sourceFile, destinationFile);
        }
    }
}
