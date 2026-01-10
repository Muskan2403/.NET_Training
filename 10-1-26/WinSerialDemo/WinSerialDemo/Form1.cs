using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//For Binary Serialization
using System.Runtime.Serialization.Formatters.Binary;
//For XML Serialization
using System.Xml.Serialization;
//For Soap Serialization
using System.Runtime.Serialization.Formatters.Soap;

namespace WinSerialDemo
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

        private void btnBinSerialize_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.Id = Convert.ToInt32(txtEmployeeID.Text);
            emp1.Name = txtName.Text;
            emp1.Salary = Convert.ToInt32(txtSalary.Text);

            //Binary Serialization code below
            FileStream fs = new FileStream(@"D:\.Net\BinSerialize.bin",FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, emp1);
            fs.Close();
            //-------------------------------------

            foreach(Control item in this.Controls)
            {
                if(item.GetType() == typeof(TextBox))
                {
                    TextBox txtBox = (TextBox)item;
                    txtBox.Clear();
                }
            }
            MessageBox.Show("Record Added...");
        }

        private void btnBinDeSeialize_Click(object sender, EventArgs e)
        {
            //Binary Serialization code below
            FileStream fs = new FileStream(@"D:\.Net\BinSerialize.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();

            //-----------------------------------------
            Employee emp1 = (Employee) bf.Deserialize(fs);
            txtEmployeeID.Text = emp1.Id.ToString();
            txtName.Text = emp1.Name;
            txtSalary.Text = emp1.Salary.ToString();
        }

        private void btnXMLSerialize_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.Id = Convert.ToInt32(txtEmployeeID.Text);
            emp1.Name = txtName.Text;
            emp1.Salary = Convert.ToInt32(txtSalary.Text);

            //XML Serialization code below
            FileStream fs = new FileStream(@"D:\.Net\XMLSerialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            xs.Serialize(fs, emp1);
            //-------------------------------

            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox txtBox = (TextBox)item;
                    txtBox.Clear();
                }
            }
            fs.Close();
            MessageBox.Show("Record Added...");

        }

        private void btnXMLDeSerialize_Click(object sender, EventArgs e)
        {
            //XML Serialization
            FileStream fs = new FileStream(@"D:\.Net\XMLSerialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Employee));

            //-----------------------------------------
            Employee emp1 = (Employee)xs.Deserialize(fs);
            txtEmployeeID.Text = emp1.Id.ToString();
            txtName.Text = emp1.Name;
            txtSalary.Text = emp1.Salary.ToString();
            fs.Close();
        }

        private void btnSoapSerialize_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.Id = Convert.ToInt32(txtEmployeeID.Text);
            emp1.Name = txtName.Text;
            emp1.Salary = Convert.ToInt32(txtSalary.Text);

            //Soap Serialization code below
            FileStream fs = new FileStream(@"D:\.Net\SoapSerialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SoapFormatter bf = new SoapFormatter();
            bf.Serialize(fs, emp1);
            fs.Close();
            //-------------------------------------

            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox txtBox = (TextBox)item;
                    txtBox.Clear();
                }
            }
            fs.Close();
            MessageBox.Show("Record Added...");
        }

        private void btnSoapDeSerialize_Click(object sender, EventArgs e)
        {
            //Soap Serialization
            FileStream fs = new FileStream(@"D:\.Net\SoapSerialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SoapFormatter bf = new SoapFormatter();

            //-----------------------------------------
            Employee emp1 = (Employee)bf.Deserialize(fs);
            txtEmployeeID.Text = emp1.Id.ToString();
            txtName.Text = emp1.Name;
            txtSalary.Text = emp1.Salary.ToString();
            fs.Close();
        }
    }
}
