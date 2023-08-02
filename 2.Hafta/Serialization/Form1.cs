using System.Windows.Forms;
using System.Xml.Serialization;

namespace Serialization
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

        private void btnSerialized_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                Name = txtName.Text,
                Phone = txtPhone.Text,
                DoB = dateTimeP.Value,
                Department = txtDepartment.Text,
                Salary = Convert.ToInt32(txtSalary.Text),
                additonalInfo = "Serileþme istemiyoruz"

            };
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            FileStream fsout = new FileStream("employee.xml", FileMode.Create, FileAccess.Write, FileShare.None);

            try
            {
                using (fsout)
                {
                    xs.Serialize(fsout, emp);
                    MessageBox.Show("Bilgiler Serialize Edildi");

                    txtName.Text = "";
                    txtPhone.Text = "";
                    txtDepartment.Text = "";
                    txtSalary.Text = "";
                    dateTimeP.Value = System.DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();

            }
            finally
            {
                fsout.Close();
            }
        }

        private void btnDeserialized_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();

            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            FileStream fsin = new FileStream("employee.xml", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (fsin)
                {
                    emp = (Employee)xs.Deserialize(fsin);
                    MessageBox.Show("Object DeSerilize Edildi.");

                    txtName.Text = emp.Name;
                    txtPhone.Text = emp.Phone;
                    dateTimeP.Value = emp.DoB;
                    txtDepartment.Text = emp.Department;
                    txtSalary.Text = Convert.ToString(emp.Salary);
                }
            }

            catch (Exception ex)
            {
                ex.Message.ToString();

            }
        }
    }
}