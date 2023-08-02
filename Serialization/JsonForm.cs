﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Serialization
{
    public partial class JsonForm : Form
    {
        public JsonForm()
        {
            InitializeComponent();
        }

        private void btnDosyayaYaz_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            product.Name = "Apple";
            product.ExpireDate = new DateTime(2008, 12, 28);


            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(@"C:\Users\esman\OneDrive\Masaüstü\projects\asp.net-projects\btkakademi\json.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, product);
            }
        }

        private void btnJsonOku_Click(object sender, EventArgs e)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader file = File.OpenText(@"C:\Users\esman\OneDrive\Masaüstü\projects\asp.net-projects\btkakademi\json.json"))
            using (JsonReader reader = new JsonTextReader(file))
            {
                Product product = (Product)serializer.Deserialize(reader, typeof(Product));
                MessageBox.Show(product.Name);

            }
        }
    }
}
