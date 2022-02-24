using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Employer_Registration_System
{
    class ManageDB
    {
        public static string connectionString= @"Data Source=SAMILA-PC\SQLSERVER;Initial Catalog = employementDB; Integrated Security = True";
       SqlConnection Con = new SqlConnection(connectionString);


        public bool Insert(string fName, string lName, string Sex, String Email, int Salary,String Nation, String City, String Kebele, int Phone, long Acc, int HN, int Box,byte[] Image)
        {
            int inserted = 0;
            
            string Query = " INSERT INTO EmployeTbl(First_Name,Last_Name,Sex,Email,Salary,Nationality,City,Kebele,Phone_No,Account_No, House_No,Box_No,Image) VALUES (@fName,@lName,@Sex,@Email,@Salary,@Nation,@City,@Kebele,@Phone,@Acc,@HN,@Box,@Image)";
            SqlCommand command = new SqlCommand(Query, Con);
            command.Parameters.AddWithValue("@fName",fName);
            command.Parameters.AddWithValue("@lName", lName);
            command.Parameters.AddWithValue("@Sex", Sex);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Salary", Salary);
            //command.Parameters.AddWithValue("@ImageURL", ImageURL);
            command.Parameters.AddWithValue("@Nation", Nation);
            command.Parameters.AddWithValue("@City", City);
            command.Parameters.AddWithValue("@Kebele", Kebele);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Acc", Acc);
            command.Parameters.AddWithValue("@HN", HN);
            command.Parameters.AddWithValue("@Box", Box);
            command.Parameters.AddWithValue("Image",Image);


            try
            {
                Con.Open();
                inserted = command.ExecuteNonQuery();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }

            if (inserted > 0)
                return true;
            else
                return false;
        }

        public DataSet Fetching()
        {
            String Query = "Select *from EmployeTbl";
            DataSet DS = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter(Query, Con);
            try
            {
                Con.Open();
                DA.Fill(DS, "EmployeTbl");
            }
            catch
            {

            }
            finally
            {
                Con.Close();
            }
            return DS;
        }

        #region Delete
        public bool Delete(int id)
        {
            int delete = 0;
            string query = "DELETE FROM EmployeTbl WHERE ID = @id";
            SqlCommand cmd = new SqlCommand(query, Con);

            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                Con.Open();
                delete = cmd.ExecuteNonQuery();
            } catch (Exception ex)
            {

            }
            finally
            {
                Con.Close();
            }

            if (delete > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
        #endregion

        #region Update
        public bool Update(string fName, string lName, string Sex, String Email, int Salary, String Nation, String City, String Kebele, int Phone, long Acc, int HN, int Box, byte[] Image, int id)
        {
            int updated = 0;
            string query = "UPDATE EmployeTbl SET First_Name = @fName, Last_Name = @lName,Sex=@Sex,Email=@Email,Salary=@Salary,Nationality=@Nation,City=@City,Kebele=@Kebele,Phone_No=@Phone,Account_No=@Acc, House_No=@HN,Box_No=@Box,Image=@Image WHERE ID = @id";

            SqlCommand command = new SqlCommand(query, Con);
            command.Parameters.AddWithValue("@fName", fName);
            command.Parameters.AddWithValue("@lName", lName);
            command.Parameters.AddWithValue("@Sex", Sex);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Salary", Salary);
            //command.Parameters.AddWithValue("@ImageURL", ImageURL);
            command.Parameters.AddWithValue("@Nation", Nation);
            command.Parameters.AddWithValue("@City", City);
            command.Parameters.AddWithValue("@Kebele", Kebele);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Acc", Acc);
            command.Parameters.AddWithValue("@HN", HN);
            command.Parameters.AddWithValue("@Box", Box);
            command.Parameters.AddWithValue("Image", Image);
            command.Parameters.AddWithValue("@id", id);


            try
            {
                Con.Open();
                updated = command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }

            if (updated > 0)
                return true;
            else
                return false;

        }
        #endregion

        #region FetchOne
        public DataSet FetchOne(int id)
        {
            String Query = "Select * from EmployeTbl WHERE ID = " + id;
            DataSet DS = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter(Query, Con);
            try
            {
                Con.Open();
                DA.Fill(DS, "EmployeTb2");
            }
            catch
            {

            }
            finally
            {
                Con.Close();
            }
            return DS;
        }
        #endregion

    }
}
