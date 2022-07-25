using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESOFT_STMS
{
    public partial class formStudentDashboard : Form
    {
        string id;
        string firstName;
        string lastName;
        string dOB;
        string mobile;
        string gender;
        string email;    

        public formStudentDashboard(string studentId, string studentFirstName, string studentLastName, string studentDOB, string studentMobile, string studentGender, string studentEmail)
        {
            InitializeComponent();
            labelMessage.Text = "Welcome "+studentFirstName+" "+studentLastName+"!";
            labelStudentEmail.Text = studentEmail;

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

            id = studentId;
            firstName = studentFirstName;
            lastName = studentLastName;
            dOB = studentDOB;
            mobile = studentMobile;
            gender = studentGender;
            email = studentEmail;      
        }

        private void formStudentDashboard_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
            groupBoxTab.Text = "My Account";
            listBoxDetails.Items.Clear();
            listBoxDetails.Items.Add("Student ID    : " + id);
            listBoxDetails.Items.Add("Name            : " + firstName+" "+lastName);
            listBoxDetails.Items.Add("Date of Birth : " + dOB.Substring(0,8));
            listBoxDetails.Items.Add("Mobile Number  : " + mobile);
            listBoxDetails.Items.Add("Gender         : " + gender);
            listBoxDetails.Items.Add("Email            : " + email);
        }

        private void label4_Click(object sender, EventArgs e)
        {
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

        private void listBoxDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupBoxTab.Text == "Courses") {
                
                System.Diagnostics.Process.Start("https://www.esoft.lk");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            formStartPage startpage = new formStartPage();
            startpage.Show();
            this.Hide();
        }
    }
}
