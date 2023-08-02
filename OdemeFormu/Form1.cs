namespace OdemeFormu
{
    public partial class Form1 : Form
    {
        string secilenOdemeTipi;
        OdemeManager odemeManager;
        IOdeme iOdeme;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            double tutar = Convert.ToDouble(txtTutar.Text);
            OdemeFactory factory = new OdemeFactory();
            //polimorfik obje artýk elimizde
            iOdeme = factory.GetInstance(secilenOdemeTipi);
            odemeManager = new OdemeManager(iOdeme);


        }
    }
}