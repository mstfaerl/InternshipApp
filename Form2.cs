﻿using System;
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
    public partial class Form2 : Form
    {

        //Sql Connection
        SqlConnection connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\m07er\\source\\repos\\InternshipApp\\Database.mdf;Integrated Security=True");

        public Form2()
        {
            InitializeComponent();
        }

        private void AddMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                SqlCommand query = new SqlCommand("insert into MaterialsTable(Name,Description,Quantity,Supplier,Price,AlarmLevel) values('" + materialName.Text + "','" + materialDescription.Text + "','" + Convert.ToInt32(materialQuantity.Text) + "','" + materialSupplier.Text + "','" + float.Parse(materialPrice.Text) + "','" + Convert.ToInt32(alarmLevel.Text) + "')", connect);
                query.ExecuteNonQuery();  
                MessageBox.Show("Inserted Succesfully!");
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check the values you entered!" + ex.Message);
            }
            connect.Close();
        }

    }
}
