namespace OdemeFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            OdemeFactory factory = new OdemeFactory();
            var odemeInstance = factory.GetInstance(cmbOdemeTipi.SelectedItem.ToString());

            var odemeManager = new OdemeManager(odemeInstance);
            lblSonuc.Text = odemeManager.Ode(txtTutar.Text);
        }
    }
}