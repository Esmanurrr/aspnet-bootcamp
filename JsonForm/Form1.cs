using System.Formats.Asn1;
using System.Text.Json;

namespace JsonForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDosyaYaz_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            product.Name = "Apple";
            product.ExpireDate = new DateTime(2008, 12, 28);


            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Administrator\Documents\btkakademi\json.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, product);
            }
        }
    }
}