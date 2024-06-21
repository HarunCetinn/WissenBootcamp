using System.Text.Json;

namespace OgrenciSerialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = null;

            if (txtAdSoyad.Text.Trim() == "" || txtBolum.Text.Trim() == "" || txtEmail.Text.Trim() == ""
                || txtTelefon.Text.Trim() == "" || txtNotOrtalamsi.Text.Trim() == "" || dtDogumTarihi.Value.Date == DateTime.Now.Date)
            {

                MessageBox.Show("Boþ Alan Býrakmayýnýz", "Hata!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ogrenci = new Ogrenci();
                ogrenci.OgrenciID = 10;
                ogrenci.AdiSoyadi = txtAdSoyad.Text;
                ogrenci.DogumTarihi = dtDogumTarihi.Value;
                ogrenci.Bolumu = txtBolum.Text;
                ogrenci.Email = txtEmail.Text;
                ogrenci.Telefon = txtTelefon.Text; ;
                ogrenci.NotOrtalamasi = double.Parse(txtNotOrtalamsi.Text);
                ogrenci.OgrenciHakkinda = rtxtOgrenciBilgileri.Text;

                try
                {
                    if (ogrenci != null)
                    {
                        FileStream stream = new FileStream("Ogrenci.json", FileMode.Append, FileAccess.Write);
                        using (stream)
                        {
                            JsonSerializer.Serialize(stream, ogrenci);
                            MessageBox.Show("Dosyay Ogrenci Bilgileri JSON Formatýnda Yazýldý...", "Baþarýlý iÞlem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Beklenmedik Bir Hata Alýndý....", "HATA!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            try
            {
                FileStream stream = new FileStream("ogrenci.json", FileMode.Open, FileAccess.Read);

                using (stream)
                {
                    ogrenci = JsonSerializer.Deserialize<Ogrenci>(stream);
                    txtAdSoyad.Text = ogrenci.AdiSoyadi;
                    dtDogumTarihi.Value = ogrenci.DogumTarihi;
                    txtEmail.Text = ogrenci.Email;
                    txtTelefon.Text = ogrenci.Telefon;
                    txtBolum.Text = ogrenci.Bolumu;
                    txtNotOrtalamsi.Text = ogrenci.NotOrtalamasi.ToString();
                    rtxtOgrenciBilgileri.Text = ogrenci.OgrenciHakkinda;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Öðrenci Bilgileri OKunamadý...", "Hata!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
