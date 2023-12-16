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

            // oyunun baþladýðý belirten deðiþkene true ata
            //oyunTimer =

            // oyun baþladýðý zaman önce timer'ýmýzý baþlatalým.
            oyunTimer.Start();

            // program rastgele sayý üretecek.
            uretilenSayi = rastgeleUretici.Next(1, 101);

            // progress bar'ýmýzýn durumunu ayarlayalým.
            // yani doluluk oranýný en yüksek deðere alalým.
            // O'da 100 olacak. çünkü oyun baþladýðýnda porgressbar en baþta olamalý.(süre yeni baþlýyor.)
            progressBar.Value = progressBar.Maximum;

            // Oyun baþladýðý zaman sayý kutusunu aç
            txtSayi.Enabled = true;

        }

        private void txtSayi_TextChanged(object sender, EventArgs e)
        {
            // metni her deðiþtiðinde buraya gelir.
            //Eðer tahmin butonu aktif deðilse aktif et.


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
                // Tahmin edilen sayýyý al.

                tahminEdilen = Convert.ToInt32(txtSayi.Text);

                if (tahminEdilen == uretilenSayi)
                {
                    lblBilgi.Text = "KAZANDINIZ!!!";
                    oyunTimer.Stop();
                }
                else if (tahminEdilen < uretilenSayi)
                {
                    lblBilgi.Text = "Daha büyük sayý giriniz.";
                    txtSayi.Clear();
                }
                else
                {
                    lblBilgi.Text = "Daha küçük sayý giriniz.";
                    txtSayi.Clear();
                }

            }
            catch (FormatException)
            {
                lblBilgi.Text = "Geçerli bir sayý giriniz!";
                txtSayi.Clear();
            }
        }

        private void oyunTimer_Tick(object sender, EventArgs e)
        {

            //progres bar'ýn deðerini azalt.
            progressBar.Value--;

            // burasý her saniyede çalýþacak.
            // çünkü timer'ýn interval'ýný 100 ms yaptýk. o'da 1 sn'ye takabül eder.

            lblSayac.Text = progressBar.Value.ToString();

            //lblSayac.Text = (progressBar).ToString(); 

            // progressbar'ýn sdeðeri sýfýr olduðu zaman yani süre bittiði zaman timer'ý durdur.

            if (progressBar.Value >= 30)
            {
                lblMesaj.Text = "Süre daha var :)";
            }
            else if (progressBar.Value >= 20)
            {
                lblMesaj.Text = "Süre yavaþ yavaþ azalýyor!";
            }
            else if (progressBar.Value >= 1)
            {
                lblMesaj.Text = "Süre Çok az kaldý!";
            }
            else
            {
                lblMesaj.Text = "Kaybettiniz!";
                oyunTimer.Stop();
            }
        }
    }
}