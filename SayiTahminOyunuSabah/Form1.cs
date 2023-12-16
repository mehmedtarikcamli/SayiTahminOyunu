namespace SayiTahminOyunuSabah
{
    public partial class Form1 : Form
    {
        Random rastgeleUretici = new Random();
        int uretilenSayi, tahminEdilen;


        public Form1()
        {
            InitializeComponent();
            btnTahmin.Enabled = false;
            progressBar.Maximum = 60;
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {

            // oyunun ba�lad��� belirten de�i�kene true ata
            //oyunTimer =

            // oyun ba�lad��� zaman �nce timer'�m�z� ba�latal�m.
            oyunTimer.Start();

            // program rastgele say� �retecek.
            uretilenSayi = rastgeleUretici.Next(1, 101);

            // progress bar'�m�z�n durumunu ayarlayal�m.
            // yani doluluk oran�n� en y�ksek de�ere alal�m.
            // O'da 100 olacak. ��nk� oyun ba�lad���nda porgressbar en ba�ta olamal�.(s�re yeni ba�l�yor.)
            progressBar.Value = progressBar.Maximum;

            // Oyun ba�lad��� zaman say� kutusunu a�
            txtSayi.Enabled = true;

        }

        private void txtSayi_TextChanged(object sender, EventArgs e)
        {
            // metni her de�i�ti�inde buraya gelir.
            //E�er tahmin butonu aktif de�ilse aktif et.


            if (txtSayi.Text == "" || !int.TryParse(txtSayi.Text, out int anlikYazilanSayi)
               || (txtSayi.Text.Contains(" ") && btnTahmin.Enabled))
                btnTahmin.Enabled = false;

            else if (!btnTahmin.Enabled && !txtSayi.Text.Contains(" "))
                btnTahmin.Enabled = true;
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {

            try
            {
                // Tahmin edilen say�y� al.

                tahminEdilen = Convert.ToInt32(txtSayi.Text);

                if (tahminEdilen == uretilenSayi)
                {
                    lblBilgi.Text = "KAZANDINIZ!!!";
                    oyunTimer.Stop();
                }
                else if (tahminEdilen < uretilenSayi)
                {
                    lblBilgi.Text = "Daha b�y�k say� giriniz.";
                    txtSayi.Clear();
                }
                else
                {
                    lblBilgi.Text = "Daha k���k say� giriniz.";
                    txtSayi.Clear();
                }

            }
            catch (FormatException)
            {
                lblBilgi.Text = "Ge�erli bir say� giriniz!";
                txtSayi.Clear();
            }
        }

        private void oyunTimer_Tick(object sender, EventArgs e)
        {

            //progres bar'�n de�erini azalt.
            progressBar.Value--;

            // buras� her saniyede �al��acak.
            // ��nk� timer'�n interval'�n� 100 ms yapt�k. o'da 1 sn'ye takab�l eder.

            lblSayac.Text = progressBar.Value.ToString();

            //lblSayac.Text = (progressBar).ToString(); 

            // progressbar'�n sde�eri s�f�r oldu�u zaman yani s�re bitti�i zaman timer'� durdur.

            if (progressBar.Value >= 30)
            {
                lblMesaj.Text = "S�re daha var :)";
            }
            else if (progressBar.Value >= 20)
            {
                lblMesaj.Text = "S�re yava� yava� azal�yor!";
            }
            else if (progressBar.Value >= 1)
            {
                lblMesaj.Text = "S�re �ok az kald�!";
            }
            else
            {
                lblMesaj.Text = "Kaybettiniz!";
                oyunTimer.Stop();
            }
        }
    }
}