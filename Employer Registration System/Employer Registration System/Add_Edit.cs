using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employer_Registration_System
{
    public partial class Add_Edit : Form
    {
        DataSet DS;
        ManageDB DB = new ManageDB();
        int id;
        public Add_Edit(int id)
        {
            InitializeComponent();
            this.id = id;

            if (id != -1)
            {
                loadUpdateData();
            }
           
        }

        private void loadUpdateData()
        {

            DS = DB.FetchOne(id);

            fTxt.Text = DS.Tables["EmployeTb2"].Rows[0][1].ToString();
            l_Txt.Text = DS.Tables["EmployeTb2"].Rows[0][2].ToString();
            S_Txt.Text = DS.Tables["EmployeTb2"].Rows[0][3].ToString();
            E_txt.Text = DS.Tables["EmployeTb2"].Rows[0][4].ToString();
            Sa_txt.Text = DS.Tables["EmployeTb2"].Rows[0][5].ToString();
            N_txt.Text = DS.Tables["EmployeTb2"].Rows[0][6].ToString();
            C_txt.Text = DS.Tables["EmployeTb2"].Rows[0][7].ToString();
            Ke_txt.Text = DS.Tables["EmployeTb2"].Rows[0][8].ToString();
            P_txt.Text = DS.Tables["EmployeTb2"].Rows[0][9].ToString();
            Acc_txt.Text = DS.Tables["EmployeTb2"].Rows[0][10].ToString();
            H_txt.Text = DS.Tables["EmployeTb2"].Rows[0][0].ToString();
            PB_txt.Text = DS.Tables["EmployeTb2"].Rows[0][0].ToString();

            Byte[] Byte_Img = new Byte[0];
            Byte_Img = (Byte[])DS.Tables["EmployeTb2"].Rows[0][13];
            MemoryStream stream = new MemoryStream(Byte_Img);
            pictureBox1.Image = Image.FromStream(stream);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream stream;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            if(open.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    if((stream=open.OpenFile())!= null)
                    {
                        string FileName = open.FileName;
                        if (stream.Length > 512000)
                        {
                            MessageBox.Show("File size limit exceed !");
                        }
                        else
                            pictureBox1.Load(FileName);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error!: Could not load the file" + ex.Message);
                }


               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
            byte[] pic = stream.ToArray();
            
            bool inserted;
            inserted = DB.Insert(fTxt.Text, l_Txt.Text, S_Txt.Text, E_txt.Text, Convert.ToInt32(Sa_txt.Text), N_txt.Text, C_txt.Text, Ke_txt.Text, Convert.ToInt32(P_txt.Text), Convert.ToInt64(Acc_txt.Text), Convert.ToInt32(H_txt.Text),Convert.ToInt32( PB_txt.Text),pic);
            if (inserted == true)
                MessageBox.Show("Saved Successfully!");
            else
                MessageBox.Show("Error! Not Saved !");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
        public  PictureBox myPB()
        {
            return pictureBox1;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
            byte[] pic = stream.ToArray();

            bool inserted;
            inserted = DB.Update(fTxt.Text, l_Txt.Text, S_Txt.Text, E_txt.Text, Convert.ToInt32(Sa_txt.Text), N_txt.Text, C_txt.Text, Ke_txt.Text, Convert.ToInt32(P_txt.Text), Convert.ToInt64(Acc_txt.Text), Convert.ToInt32(H_txt.Text), Convert.ToInt32(PB_txt.Text), pic, id);
            if (inserted == true)
                MessageBox.Show("Updated Successfully!");
            else
                MessageBox.Show("Error! Not Updated !");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool delete;
            delete = DB.Delete(id);
            if (delete == true)
            {
                MessageBox.Show("Deleted successfully");
                this.Hide();
            } else
            {
                MessageBox.Show("Deletion failed");
            }
        }
    }
}
