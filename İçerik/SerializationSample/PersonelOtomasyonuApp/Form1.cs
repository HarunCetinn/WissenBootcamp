namespace PersonelOtomasyonuApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        #region Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbUNvan.Items.AddRange(Enum.GetNames(typeof(Unvan)));
        }
        #endregion

        #region Resim Seçme
        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Personel Resmi(png,jpg,gif)|*.png;*.jpg;*.gif";

            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pbResim.Image = Image.FromFile(ofd.FileName);//Resim dosyasýný picturebox controlünün IMage property sine ekledik.
                pbResim.Tag = Path.GetExtension(ofd.FileName);//GetExtension metodu dosya seçildiðinde dosyanýn uzantýsýný alýr Noktadan sonraki kýsým
            }
        }
        #endregion

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p = PersonelDoldur(p);
            ListViewItem lvi = ListViewDoldur(p);
            lvPersoneller.Items.Add(lvi);


        }

        private ListViewItem ListViewDoldur(Personel p)
        {
            ListViewItem lvi = new ListViewItem(p.TCKN);
            lvi.SubItems.Add($"{p.Ad} {p.Soyad}");
            lvi.SubItems.Add($"{p.DogumTarihi}");
            lvi.SubItems.Add($"{p.Email}");
            lvi.SubItems.Add($"{p.IseGirisTarihi}");
            lvi.SubItems.Add($"{p.Unvan}");
            lvi.Tag = p;

            return lvi;
        }

        private Personel PersonelDoldur(Personel p)
        {
            p.Ad = txtAd.Text;
            p.Soyad = txtSoyad.Text;
            p.TCKN = txtTcKimlikNo.Text;
            p.Telefon = txtTelefon.Text;
            p.DogumTarihi = dtDogumTarihi.Value;
            p.Email = txtEmail.Text;
            p.IseGirisTarihi = dtIseGirisTarihi.Value;
            p.Unvan = (cmbUNvan.Text == "" ? Unvan.Belirtilmedi : (Unvan)Enum.Parse(typeof(Unvan), cmbUNvan.Text)).ToString();
            p.PersonelResmi = Guid.NewGuid() + pbResim.Tag.ToString();
            pbResim.Image.Save(Application.StartupPath + "Images/" + p.PersonelResmi);

            return p;
                
        }
    }
}
