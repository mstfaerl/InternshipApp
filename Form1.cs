using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Media;
using NuGet.Protocol.Core.Types;

namespace InternshipApp
{
    public partial class Form1 : Form
    {

        

        //Sql Connection
        SqlConnection connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\m07er\\source\\repos\\InternshipApp\\Database.mdf;Integrated Security=True");

        //Datatable for datagridview
        private DataTable dt;

        //Name list
        List<QuantityAlarm> nameList = null;

        //Sound
        SoundPlayer sound = new SoundPlayer();

        public Form1()
        {
            InitializeComponent();
            listMaterial();
            alarmButton.Visible = false;
        }

        //public void formUpdate()
        //{
        //    listMaterial();
        //}


        private void MaterialForm_Shown(object sender, EventArgs e)
        {
            checkQuantity();
        }

        //DELETE
        private void DeleteMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                SqlCommand query = new SqlCommand("delete from MaterialsTable where Id='" + sId + "'", connect);
                query.ExecuteNonQuery();
                MessageBox.Show("Deleted Succesfully!");
                listMaterial();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check the values you entered");
            }
            connect.Close();

        }

        //LIST
        public void listMaterial()
        {

            connect.Open();
            string query = "select * from MaterialsTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, connect);
            dt = new DataTable();
            sda.Fill(dt);
            materialList.DataSource = dt;
            connect.Close();
            //SqlDataReader reader = query.ExecuteReader();

            //while (reader.Read())
            //{

            //}
        }

        //SEARCH with Name
        //private void SearchingName_TextChanged(object sender, EventArgs e)
        //{
        //    DataView dv = dt.DefaultView;
        //    dv.RowFilter = string.Format("Name like '" + searchingText.Text + "' + '%' OR Description like '" + searchingText.Text + "' + '%'");
        //    materialList.DataSource = dv;

        //}

        //When selected item in datagridview putting data in textbox
        

        //Quantity control
        public void checkQuantity()
        {
            connect.Open();
            SqlCommand query = new SqlCommand("select Quantity,Name from MaterialsTable where Quantity < 5", connect);
            SqlDataReader dr = query.ExecuteReader();
            QuantityAlarm alarmQuantityName = null;
            nameList = new List<QuantityAlarm>();
            while (dr.Read())
            {
                alarmQuantityName = new QuantityAlarm(Convert.ToInt32(dr["Quantity"]), Convert.ToString(dr["Name"]));
                nameList.Add(alarmQuantityName);
            }

            sound.SoundLocation = "alarm.wav";

            if(nameList.Count != 0)
            {
                alarmButton.Visible = true;
                sound.PlayLooping();
                foreach (QuantityAlarm qAlarm in nameList)
                {
                    string message = "You have " + Convert.ToString(qAlarm.AlarmQuantity).Trim() + " " + qAlarm.AlarmName.Trim() + " " +". Your " + qAlarm.AlarmName.Trim() + " is almost exhausted!";
                    MessageBox.Show(message,"Alarm",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                sound.Stop();
                alarmButton.Visible = false;
                MessageBox.Show("You have enough metarials.");
            }

            connect.Close();
        }

        private void AlarmButton_Click(object sender, EventArgs e)
        {
            sound.Stop();
            alarmButton.Visible = false;
        }

        private void AddNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 addNew = new Form2();
            addNew.Show();
            this.Hide();
        }

        //private void MaterialList_DoubleClick(object sender, EventArgs e)
        //{
        //    Form3 updateMat = new Form3();
        //    updateMat.Show();
        //}

        private void SearchingText_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Name like '" + searchingText.Text + "' + '%' OR Description like '" + searchingText.Text + "' + '%'");
            materialList.DataSource = dv;
        }

        public static int uId;
        public static string uName;
        public static string uDescription;
        public static int uQuantity;
        public static string uSupplier;
        public static float uPrice;
        
        private void MaterialList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.materialList.Rows[e.RowIndex];
                uId = Convert.ToInt16(row.Cells["Id"].Value);
                uName = row.Cells["Name"].Value.ToString();
                uDescription = row.Cells["Description"].Value.ToString();
                uQuantity = Convert.ToInt32(row.Cells["Quantity"].Value.ToString());
                uSupplier = row.Cells["Supplier"].Value.ToString();
                uPrice = float.Parse(row.Cells["Price"].Value.ToString());
                Form3 updateMat = new Form3();
                updateMat.Show();
            }
            this.Hide();
        }

        public static int sId;

        private void MaterialList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.materialList.Rows[e.RowIndex];
                sId = Convert.ToInt16(row.Cells["Id"].Value);
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UpdateGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        public void gitUpdate()
        {
            Repository.Clone("https://github.com/mstfaerl/git-dersleri.git", @"D:\GithubFile");
        }
        


        //private void CheckMaterial_Click(object sender, EventArgs e)
        //{
        //    this.checkQuantity();
        //    if (this.nameList.Count != 0)
        //    {
        //        checkMaterial.Enabled = true;
        //    }
        //    else
        //    {
        //        checkMaterial.Enabled = false;
        //    }
        //    checkMaterial.Text = "Checked";
        //    foreach (string str in nameList)
        //    {
        //        MessageBox.Show(str + "is almost exhausted!");
        //    }
        //    checkMaterial.Enabled = false;

        //}



        //private void SearchingBox_KeyPress_1(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)13)
        //    {

        //        dv.RowFilter = "Name like '%' + '" + searchingBox.Text + "' + '%' "; ;
        //        materialList.DataSource = dv.ToTable();
        //    }
        //}

        //private void SearchingBox_TextChanged(object sender, EventArgs e)
        //{
        //    DataView dv = dt.DefaultView;
        //    dv.RowFilter = string.Format("Name like '%{0}%'", searchingName.Text);
        //    materialList.DataSource = dv;
        //}
    }
}
