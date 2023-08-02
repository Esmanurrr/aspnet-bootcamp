using System.DirectoryServices.ActiveDirectory;

namespace AttributeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void lblAd_Click(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = txtAd.Text;
            ogrenci.Soyad = txtSoyad.Text;
            ogrenci.Bolum = txtBolum.Text;

            if (!ZorunlulukKontrolu.Dogrula(ogrenci))
            {
                Console.WriteLine("Öðrenci bilgileri doðrulamadan geçemedi");
            }
            else
            {
                Console.WriteLine("Form baþarýlý");
            }
        }
    }
}