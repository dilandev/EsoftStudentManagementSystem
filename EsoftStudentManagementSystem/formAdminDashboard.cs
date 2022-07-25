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
using ESOFT_STMS.Helper;

namespace ESOFT_STMS
{
    public partial class formAdminDashboard : Form
    {
        SqlConnection con;

        string id;
        string firstName;
        string lastName;
        string dOB;
        string mobile;
        string gender;
        string email;

        public formAdminDashboard(string adminId, string adminFirstName, string adminLastName, string adminDOB, string adminMobile, string adminGender, string adminEmail)
        {
            InitializeComponent();
            labelMessage.Text = "Welcome " + adminFirstName + " " + adminLastName + "!";
            labelStudentEmail.Text = adminEmail;

            string course1 = "SCHOOL OF COMPUTING";
            string course2 = "SCHOOL OF BUSINESS";
            string course3 = "SCHOOL OF ENGINEERING & TECHNOLOGY";
            string course4 = "SCHOOL OF TOURISM & HOSPITALITY";
            string course5 = "LANGUAGE ACADEMY";
            string course6 = "QUANTITY SURVEYING";
            listBoxDetails.Items.Add(course1);
            listBoxDetails.Items.Add(course2);
            listBoxDetails.Items.Add(course3);
            listBoxDetails.Items.Add(course4);
            listBoxDetails.Items.Add(course5);
            listBoxDetails.Items.Add(course6);
            groupBoxTab.Text = "Courses";

            id = adminId;
            firstName = adminFirstName;
            lastName = adminLastName;
            dOB = adminDOB;
            mobile = adminMobile;
            gender = adminGender;
            email = adminEmail;

            textBoxSearch.Visible = false;
            buttonSearch.Visible = false;
            dataGridViewStudent.Visible = false;
            labelSearchby.Visible = false;
            radioButtonSearchName.Visible = false;
            radioButtonSearchEmail.Visible = false;
            buttonReset.Visible = false;
            groupBoxTab.Text = "Courses";
        }

        private void formAdminDashboard_Load(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
            formStartPage startpage = new formStartPage();
            this.Hide();
            startpage.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            listBoxDetails.Visible = false;
            dataGridViewStudent.Visible = true;
            textBoxSearch.Visible = true;
            buttonSearch.Visible = true;
            labelSearchby.Visible = true;
            radioButtonSearchName.Visible = true;
            radioButtonSearchEmail.Visible = true;
            buttonReset.Visible = true;
            groupBoxTab.Text = "Student Details";
            con = new SqlConnection(DBHelper.getConnectionString());
            string query = "SELECT StudentId, FirstName, LastName, DOB, Mobile, Gender, Email FROM StudentSignupInfo";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
            dataGridViewStudent.DataSource = dataSet.Tables[0];
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(DBHelper.getConnectionString());
            string query = "SELECT StudentId, FirstName, LastName, DOB, Mobile, Gender, Email FROM StudentSignupInfo";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
            dataGridViewStudent.DataSource = dataSet.Tables[0];
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBoxSearch.Visible = false;
            buttonSearch.Visible = false;
            dataGridViewStudent.Visible = false;
            labelSearchby.Visible = false;
            radioButtonSearchName.Visible = false;
            radioButtonSearchEmail.Visible = false;
            buttonReset.Visible = false;
            groupBoxTab.Visible = true;
            listBoxDetails.Visible = true;
            groupBoxTab.Text = "My Account";
            listBoxDetails.Items.Clear();
            listBoxDetails.Items.Add("Admin ID      : " + id);
            listBoxDetails.Items.Add("Name            : " + firstName + " " + lastName);
            listBoxDetails.Items.Add("Date of Birth : " + dOB.Substring(0, 8));
            listBoxDetails.Items.Add("Mobile Number  : " + mobile);
            listBoxDetails.Items.Add("Gender         : " + gender);
            listBoxDetails.Items.Add("Email            : " + email);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            listBoxDetails.Visible = true;
            textBoxSearch.Visible = false;
            buttonSearch.Visible = false;
            dataGridViewStudent.Visible = false;
            labelSearchby.Visible = false;
            radioButtonSearchName.Visible = false;
            radioButtonSearchEmail.Visible = false;
            buttonReset.Visible = false;
            string course1 = "SCHOOL OF COMPUTING";
            string course2 = "SCHOOL OF BUSINESS";
            string course3 = "SCHOOL OF ENGINEERING & TECHNOLOGY";
            string course4 = "SCHOOL OF TOURISM & HOSPITALITY";
            string course5 = "LANGUAGE ACADEMY";
            string course6 = "QUANTITY SURVEYING";
            groupBoxTab.Text = "Courses";
            listBoxDetails.Items.Clear();
            listBoxDetails.Items.Add(course1);
            listBoxDetails.Items.Add(course2);
            listBoxDetails.Items.Add(course3);
            listBoxDetails.Items.Add(course4);
            listBoxDetails.Items.Add(course5);
            listBoxDetails.Items.Add(course6);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (radioButtonSearchName.Checked)
            {
                con = new SqlConnection(DBHelper.getConnectionString());
                string query = "SELECT * FROM StudentSignupInfo WHERE FirstName='" + textBoxSearch.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataSet dataSet = new DataSet();
                sda.Fill(dataSet);
                dataGridViewStudent.DataSource = dataSet.Tables[0];
            }
            else
            {
                con = new SqlConnection(DBHelper.getConnectionString());
                string query = "SELECT * FROM StudentSignupInfo WHERE FirstName='" + textBoxSearch.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataSet dataSet = new DataSet();
                sda.Fill(dataSet);
                dataGridViewStudent.DataSource = dataSet.Tables[0];
            }
        }

        private void listBoxDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupBoxTab.Text == "Courses")
            {

                System.Diagnostics.Process.Start("https://www.esoft.lk");
            }
        }

        private void labelTeacher_Click(object sender, EventArgs e)
        {
            listBoxDetails.Visible = false;
            dataGridViewStudent.Visible = true;
            textBoxSearch.Visible = true;
            buttonSearch.Visible = true;
            labelSearchby.Visible = true;
            radioButtonSearchName.Visible = true;
            radioButtonSearchEmail.Visible = true;
            buttonReset.Visible = true;
            groupBoxTab.Text = "Teacher Details";
            con = new SqlConnection(DBHelper.getConnectionString());
            string query = "SELECT TeacherId, FirstName, LastName, DOB, Mobile, Gender, Email FROM TeacherSignupInfo";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
            dataGridViewStudent.DataSource = dataSet.Tables[0];
        }
    }
}
