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
            //Disk �zerindeki S�r�c� bilgilerini almak i�in kullan�lan s�n�f DriveINfo s�n�f�. 
            DriveInfo di = new DriveInfo("C:\\");
            string driveInfo = string.Empty;
            driveInfo = $"S�r�c� Ad� : {di.Name}\n" +
                $"S�r�c� �n Ad� : {di.VolumeLabel}\n" +
                $"Toplam Boyut : {di.TotalSize}\n" +
                $"Bo� Alan Boyutu : {di.TotalFreeSpace}\n" +
                $"Kullan�labilir Bo� Alan : {di.AvailableFreeSpace}";

            MessageBox.Show(driveInfo);
        }

        private void btnDirectoryINfo_Click(object sender, EventArgs e)
        {
            //Bir kals�r�n bilgileirni i�letim sisteminden alabilmek i�in kullan�lan s�n�f DirectoryInfo s�n�f�d�r
            DirectoryInfo dirInfo = new DirectoryInfo("C:\\UygulamaIcerikleri");
            string directoryInfo = string.Empty;
            directoryInfo = $"Klas�r Yolu : {dirInfo.FullName}\n" +
                $"Klas�r Ad� : {dirInfo.Name}\n" +
                $"Bir �st Klas�r Ad� : {dirInfo.Parent}\n" +
                $"Dosya T�r� : {dirInfo.Attributes}\n" +
                $"Olu�turulma Tarihi : {dirInfo.CreationTime.ToString("yyyy-MM-dd HH:mm:ss")}\n" +
                $"Son De�i�itirlme Tarihi : {dirInfo.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss")}";

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
