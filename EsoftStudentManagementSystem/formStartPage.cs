using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using ESOFT_STMS.Helper;

namespace ESOFT_STMS
{
    public partial class formStartPage : Form
    {
        SqlCommand cmd;
        SqlConnection con;

        public formStartPage()
        {
            InitializeComponent();

            textBoxPassword.UseSystemPasswordChar = true;
            textBoxRetypePassword.UseSystemPasswordChar = true;
            textBoxPassword.MaxLength = 18;
            textBoxRetypePassword.MaxLength = 18;
            textBoxMobile.MaxLength = 10;
            labelMessage.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
            formLoginPage loginPage = new formLoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLoginPage loginPage = new formLoginPage();
            loginPage.Show();
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxRetypePassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxRetypePassword.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.TextLength < 3 || textBoxLastName.TextLength < 3)
            {
                labelMessage.Text = "Enter your name correctly";
                labelMessage.ForeColor = Color.Red;
                labelMessage.Visible = true;
            }
            else if (textBoxMobile.TextLength < 10)
            {
                labelMessage.Text = "Enter your contact number correctly";
                labelMessage.ForeColor = Color.Red;
                labelMessage.Visible = true;
            }
            else if (textBoxMobile.Text.Substring(0, 1).Contains("0") == false)
            {
                labelMessage.Text = "Enter your contact number correctly";
                labelMessage.ForeColor = Color.Red;
                labelMessage.Visible = true;
            }
            else if (textBoxEmail.TextLength < 10 || textBoxEmail.Text.Contains("@") == false || textBoxEmail.Text.Contains(".com") == false)
            {
                labelMessage.Text = "Enter your contact email correctly";
                labelMessage.ForeColor = Color.Red;
                labelMessage.Visible = true;
            }
            else if (textBoxPassword.TextLength < 1 || textBoxRetypePassword.TextLength < 1)
            {
                labelMessage.Text = "Please choose a password for your account";
                labelMessage.ForeColor = Color.Red;
                labelMessage.Visible = true;
            }
            else if (textBoxPassword.TextLength < 4 || textBoxRetypePassword.TextLength < 4)
            {
                labelMessage.Text = "Please choose a strong password";
                labelMessage.ForeColor = Color.Red;
                labelMessage.Visible = true;
            }
            else if (textBoxPassword.Text != textBoxRetypePassword.Text)
            {
                labelMessage.Text = "Retype the password correctly";
                labelMessage.ForeColor = Color.Red;
                labelMessage.Visible = true;
            }
            else
            {
                try
                {
                    string ID = "";
                    string firstName = textBoxFirstName.Text;
                    string lastName = textBoxLastName.Text;
                    string dateOfBirth = dateTimePickerDOB.Text;
                    string mobileNo = textBoxMobile.Text;
                    string email = textBoxEmail.Text;
                    string password = textBoxPassword.Text;
                    string gender;
                    if (radioButtonMale.Checked)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }

                    if (radioButtonStudent.Checked)
                    {
                        con = new SqlConnection(DBHelper.getConnectionString());
                        string queryAuthentication = "SELECT * FROM StudentSignupInfo WHERE Email='" + textBoxEmail.Text + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(queryAuthentication, con);
                        DataTable dataTable1 = new DataTable();
                        sda.Fill(dataTable1);

                        if (dataTable1.Rows.Count > 0)
                        {
                            labelMessage.Text = "There's an existing account from this email. Please try another email address.";
                            labelMessage.ForeColor = Color.Red;
                            labelMessage.Visible = true;
                        }
                        else
                        {
                            con.Open();
                            string queryIdCheck = "SELECT TOP 1 StudentID FROM StudentSignupInfo ORDER BY StudentID DESC";
                            SqlCommand cmnd = new SqlCommand(queryIdCheck, con);
                            SqlDataReader read = cmnd.ExecuteReader();

                            ID = "ES/" + DateTime.Now.Year.ToString() + "/0001";
                            while (read.Read())
                            {
                                int studentIDNumber = Int32.Parse(read[0].ToString().Substring(8, 4)) + 1;
                                ID = "ES/" + DateTime.Now.Year.ToString() + "/" + studentIDNumber.ToString().PadLeft(4, '0');
                            }
                            con.Close();
                            con.Open();
                            cmd = new SqlCommand("INSERT INTO StudentSignupInfo (StudentID,FirstName,LastName,DOB,Mobile,Gender,Email,Password) VALUES('" + ID + "', '" + firstName + "', '" + lastName + "', '" + dateOfBirth + "', '" + mobileNo + "', '" + gender + "', '" + email + "', '" + password + "')", con);
                            cmd.ExecuteNonQuery();

                            if (MessageBox.Show("Account Created Successfully. Continue to your account?", "Congratulations", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                formLoginPage loginpage = new formLoginPage();
                                loginpage.Show();
                                this.Hide();
                            }
                            else
                            {
                                textBoxFirstName.ResetText();
                                textBoxLastName.ResetText();
                                textBoxEmail.ResetText();
                                textBoxMobile.ResetText();
                                textBoxRetypePassword.ResetText();
                                textBoxPassword.ResetText();
                                dateTimePickerDOB.ResetText();
                            }
                        }
                    }
                    else if (radioButtonTeacher.Checked)
                    {
                        con = new SqlConnection(DBHelper.getConnectionString());
                        string queryAuthentication = "SELECT * FROM TeacherSignupInfo WHERE Email='" + textBoxEmail.Text + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(queryAuthentication, con);
                        DataTable dataTable1 = new DataTable();
                        sda.Fill(dataTable1);

                        if (dataTable1.Rows.Count > 0)
                        {
                            labelMessage.Text = "There's an existing account from this email. Please try another email address.";
                            labelMessage.ForeColor = Color.Red;
                            labelMessage.Visible = true;
                        }
                        else
                        {
                            con.Open();
                            string queryIdCheck = "SELECT TOP 1 TeacherID FROM TeacherSignupInfo ORDER BY TeacherID DESC";
                            SqlCommand cmnd = new SqlCommand(queryIdCheck, con);
                            SqlDataReader read = cmnd.ExecuteReader();

                            ID = "ET/" + DateTime.Now.Year.ToString() + "/0001";
                            while (read.Read())
                            {
                                int teacherIDNumber = Int32.Parse(read[0].ToString().Substring(8, 4)) + 1;
                                ID = "ET/" + DateTime.Now.Year.ToString() + "/" + teacherIDNumber.ToString().PadLeft(4, '0');
                            }
                            con.Close();

                            con.Open();
                            cmd = new SqlCommand("INSERT INTO TeacherSignupInfo (TeacherID,FirstName,LastName,DOB,Mobile,Gender,Email,Password) VALUES('" + ID + "', '" + firstName + "', '" + lastName + "', '" + dateOfBirth + "', '" + mobileNo + "', '" + gender + "', '" + email + "', '" + password + "')", con);
                            cmd.ExecuteNonQuery();
                            if (MessageBox.Show("Account Created Successfully. Continue to your account?", "Congratulations", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                formLoginPage loginpage = new formLoginPage();
                                loginpage.Show();
                                this.Hide();
                            }
                            else
                            {
                                textBoxFirstName.ResetText();
                                textBoxLastName.ResetText();
                                textBoxEmail.ResetText();
                                textBoxMobile.ResetText();
                                textBoxRetypePassword.ResetText();
                                textBoxPassword.ResetText();
                                dateTimePickerDOB.ResetText();
                            }
                        }
                    }
                    else
                    {
                        labelMessage.Text = "Enter your information correctly";
                        labelMessage.ForeColor = Color.Red;
                        labelMessage.Visible = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void textBoxMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
