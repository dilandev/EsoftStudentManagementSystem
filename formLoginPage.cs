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

namespace Final_Project___ESOFT
{
    public partial class formLoginPage : Form
    {

        SqlConnection con;

        public formLoginPage()
        {
            InitializeComponent();

            textBoxLoginPassword.UseSystemPasswordChar = true;
            labelMessage.Visible = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Hide();
            formStartPage startPage = new formStartPage();
            startPage.Show();
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
            {
                textBoxLoginPassword.UseSystemPasswordChar = false;
                
            }
            else
            {
                textBoxLoginPassword.UseSystemPasswordChar = true;
               
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {

                if (radioButtonStudent.Checked)
                {
                    con = new SqlConnection(@"Data Source=DILAN-PC;Initial Catalog=ESOFTDB;Integrated Security=True");
                    string query = "SELECT * FROM StudentSignupInfo WHERE Email='" + textBoxLoginEmail.Text + "' and Password='" + textBoxLoginPassword.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dataTable1 = new DataTable();
                    sda.Fill(dataTable1);

                    if (dataTable1.Rows.Count == 1)
                    {

                        con.Open();
                        SqlCommand cmnd = new SqlCommand(query, con);
                        SqlDataReader read = cmnd.ExecuteReader();
                        while (read.Read())
                        {

                            string dataStudentID = read[0].ToString();
                            string dataFirstName = read[1].ToString();
                            string dataLastName = read[2].ToString();
                            string dataDOB = read[3].ToString();
                            string dataMobile = read[4].ToString();
                            string dataGender = read[5].ToString();
                            string dataEmail = read[6].ToString();

                            formStudentDashboard studentDashboard = new formStudentDashboard(dataStudentID,dataFirstName,dataLastName,dataDOB,dataMobile,dataGender,dataEmail);
                            this.Hide();
                            studentDashboard.Show();

                        }

                    }
                }
                else if (radioButtonTeacher.Checked)
                {

                    con = new SqlConnection(@"Data Source=DILAN-PC;Initial Catalog=ESOFTDB;Integrated Security=True");
                    string query = "SELECT * FROM TeacherSignupInfo WHERE Email='" + textBoxLoginEmail.Text + "' and Password='" + textBoxLoginPassword.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dataTable1 = new DataTable();
                    sda.Fill(dataTable1);

                    if (dataTable1.Rows.Count == 1)
                    {

                        con.Open();
                        SqlCommand cmnd = new SqlCommand(query, con);
                        SqlDataReader read = cmnd.ExecuteReader();
                        while (read.Read())
                        {

                            string dataTeacherID = read[0].ToString();
                            string dataFirstName = read[1].ToString();
                            string dataLastName = read[2].ToString();
                            string dataDOB = read[3].ToString();
                            string dataMobile = read[4].ToString();
                            string dataGender = read[5].ToString();
                            string dataEmail = read[6].ToString();

                            formTeacherDashboard teacherDashboard = new formTeacherDashboard(dataTeacherID, dataFirstName, dataLastName, dataDOB, dataMobile, dataGender, dataEmail);
                            this.Hide();
                            teacherDashboard.Show();

                        }

                    }
                }
                else if (radioButtonAdmin.Checked)
                {

                    con = new SqlConnection(@"Data Source=DILAN-PC;Initial Catalog=ESOFTDB;Integrated Security=True");
                    string query = "SELECT * FROM AdminInfo WHERE Email='" + textBoxLoginEmail.Text + "' and Password='" + textBoxLoginPassword.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dataTable1 = new DataTable();
                    sda.Fill(dataTable1);

                    if (dataTable1.Rows.Count == 1)
                    {

                        con.Open();
                        SqlCommand cmnd = new SqlCommand(query, con);
                        SqlDataReader read = cmnd.ExecuteReader();
                        while (read.Read())
                        {

                            string dataAdminID = read[0].ToString();
                            string dataFirstName = read[1].ToString();
                            string dataLastName = read[2].ToString();
                            string dataDOB = read[3].ToString();
                            string dataMobile = read[4].ToString();
                            string dataGender = read[5].ToString();
                            string dataEmail = read[6].ToString();

                            formAdminDashboard adminDashboard = new formAdminDashboard(dataAdminID, dataFirstName, dataLastName, dataDOB, dataMobile, dataGender, dataEmail);
                            this.Hide();
                            adminDashboard.Show();

                        }
                    }
                    else
                    {

                        labelMessage.Text = "Incorrect Username or Password";
                        labelMessage.ForeColor = Color.Red;
                        labelMessage.Visible = true;

                    }
                }
                
            }
            catch
            {

            }
            finally {
                con.Close();
            }
        }
    }
}
