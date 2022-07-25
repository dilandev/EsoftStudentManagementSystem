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
    public partial class formTeacherDashboard : Form
    {
        SqlConnection con;
        
        string id;
        string firstName;
        string lastName;
        string dOB;
        string mobile;
        string gender;
        string email;

        public formTeacherDashboard(string teacherId, string teacherFirstName, string teacherLastName, string teacherDOB, string teacherMobile, string teacherGender, string teacherEmail)
        {
            InitializeComponent();
            labelMessage.Text = "Welcome " + teacherFirstName + " " + teacherLastName+"!";
            labelStudentEmail.Text =teacherEmail;

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

            id = teacherId;
            firstName = teacherFirstName;
            lastName = teacherLastName;
            dOB = teacherDOB;
            mobile = teacherMobile;
            gender = teacherGender;
            email = teacherEmail;

            textBoxSearch.Visible = false;
            buttonSearch.Visible = false;
            dataGridViewStudent.Visible = false;
            labelSearchby.Visible = false;
            radioButtonSearchName.Visible = false;
            radioButtonSearchEmail.Visible = false;
            buttonReset.Visible = false;
            groupBoxTab.Text = "Courses";

        }

        private void formTeacherDashboard_Load(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
            formStartPage startpage = new formStartPage();
            startpage.Show();
            this.Hide();
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
            string query = "SELECT StudentID, FirstName, LastName, DOB, Mobile, Gender, Email FROM StudentSignupInfo";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
            dataGridViewStudent.DataSource = dataSet.Tables[0];
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DILAN-PC;Initial Catalog=ESOFTDB;Integrated Security=True");
            string query = "SELECT StudentID, FirstName, LastName, DOB, Mobile, Gender, Email FROM StudentSignupInfo";
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
            listBoxDetails.Items.Add("Teacher ID   : " + id);
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
                con = new SqlConnection(@"Data Source=DILAN-PC;Initial Catalog=ESOFTDB;Integrated Security=True");
                string query = "SELECT * FROM StudentSignupInfo WHERE FirstName='" + textBoxSearch.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataSet dataSet = new DataSet();
                sda.Fill(dataSet);
                dataGridViewStudent.DataSource = dataSet.Tables[0];
            }
            else {

                con = new SqlConnection(@"Data Source=DILAN-PC;Initial Catalog=ESOFTDB;Integrated Security=True");
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
    }
}
