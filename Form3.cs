using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternshipApp
{
    public partial class Form3 : Form
    {

        SqlConnection connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\m07er\\source\\repos\\InternshipApp\\Database.mdf;Integrated Security=True");


        public Form3()
        {
            InitializeComponent();
            selectedMaterial();
        }

        private void selectedMaterial()
        {
            materialName.Text = Form1.uName;
            materialDescription.Text = Form1.uDescription;
            materialQuantity.Text = Form1.uQuantity.ToString();
            materialSupplier.Text = Form1.uSupplier;
            materialPrice.Text = Form1.uPrice.ToString();
        }

        private void UpdateMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                SqlCommand query = new SqlCommand("update MaterialsTable set Name='" + materialName.Text + "',Description='" + materialDescription.Text + "',Quantity='" + Convert.ToInt32(materialQuantity.Text) + "',Supplier='" + materialSupplier.Text + "',Price='" + float.Parse(materialPrice.Text) + "' where Id='" + Form1.uId + "'", connect);
                query.ExecuteNonQuery();
                MessageBox.Show("Updated Succesfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check the values you entered");
            }
            connect.Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
