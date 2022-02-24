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
using System.IO;

namespace Employer_Registration_System
{
    public partial class Home : Form
    {
        ManageDB DB = new ManageDB();
        DataSet DS;
        int id = -1;

        

        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Edit ad = new Add_Edit(-1);
            ad.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_Edit ad = new Add_Edit(id);
            ad.ShowDialog();
        }


        private void button4_Click(object sender, EventArgs e)
        {
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection("Data Source=SAMILA-PC\\SQLSERVER;Initial Catalog = employementDB; Integrated Security = True");
            string query = "select *from EmployeTbl";
            SqlDataAdapter SDA = new SqlDataAdapter(query, Con);
            DataSet DS = new DataSet();
            SDA.Fill(DS, "EmployeTbl");
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employementDBDataSet1.EmployeTbl' table. You can move, or remove it, as needed.
            this.employeTblTableAdapter.Fill(this.employementDBDataSet1.EmployeTbl);
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DS = DB.Fetching();
            if (e.RowIndex >= 0)
            {
   
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                firstN.Text = row.Cells[1].Value.ToString();
                lastN.Text = row.Cells[2].Value.ToString();
                sexMsg.Text = DS.Tables[0].Rows[e.RowIndex][3].ToString();
                EmailMsg.Text = DS.Tables[0].Rows[e.RowIndex][4].ToString();
                SalaryMsg.Text = DS.Tables[0].Rows[e.RowIndex][5].ToString();
                NatMsg.Text = DS.Tables[0].Rows[e.RowIndex][6].ToString();
                CityMsg.Text = DS.Tables[0].Rows[e.RowIndex][7].ToString();
                KebeleMsg.Text = DS.Tables[0].Rows[e.RowIndex][8].ToString();
                phoneMsg.Text = DS.Tables[0].Rows[e.RowIndex][9].ToString();
                AccountMsg.Text = DS.Tables[0].Rows[e.RowIndex][10].ToString();
                HNMsg.Text = DS.Tables[0].Rows[e.RowIndex][11].ToString();
                Boxmsg.Text = DS.Tables[0].Rows[e.RowIndex][12].ToString();
                Byte[] Byte_Img = new Byte[0];
                Byte_Img = (Byte[])DS.Tables[0].Rows[e.RowIndex][13];
                MemoryStream stream = new MemoryStream(Byte_Img);
                pictureBox1.Image = Image.FromStream(stream);

                id = Int16.Parse(DS.Tables[0].Rows[e.RowIndex][0].ToString());
            }
        }

        private void dataGridView_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Salar_Click(object sender, EventArgs e)
        {

        }

        private void SalaryMsg_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
