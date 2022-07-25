namespace ESOFT_STMS
{
    partial class formAdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdminDashboard));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.radioButtonSearchEmail = new System.Windows.Forms.RadioButton();
            this.radioButtonSearchName = new System.Windows.Forms.RadioButton();
            this.labelSearchby = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxTab = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.listBoxDetails = new System.Windows.Forms.ListBox();
            this.labelStudentEmail = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblStudentDetails = new System.Windows.Forms.Label();
            this.lblCourses = new System.Windows.Forms.Label();
            this.lblMyAccount = new System.Windows.Forms.Label();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ourAchivementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ourFacilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelTeacherDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.groupBoxTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::ESOFT_STMS.Properties.Resources.Logo;
            this.pbLogo.Location = new System.Drawing.Point(11, 50);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(298, 98);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 49;
            this.pbLogo.TabStop = false;
            // 
            // radioButtonSearchEmail
            // 
            this.radioButtonSearchEmail.AutoSize = true;
            this.radioButtonSearchEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSearchEmail.Location = new System.Drawing.Point(756, 57);
            this.radioButtonSearchEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonSearchEmail.Name = "radioButtonSearchEmail";
            this.radioButtonSearchEmail.Size = new System.Drawing.Size(78, 28);
            this.radioButtonSearchEmail.TabIndex = 48;
            this.radioButtonSearchEmail.Text = "Email";
            this.radioButtonSearchEmail.UseVisualStyleBackColor = true;
            // 
            // radioButtonSearchName
            // 
            this.radioButtonSearchName.AutoSize = true;
            this.radioButtonSearchName.Checked = true;
            this.radioButtonSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSearchName.Location = new System.Drawing.Point(597, 57);
            this.radioButtonSearchName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonSearchName.Name = "radioButtonSearchName";
            this.radioButtonSearchName.Size = new System.Drawing.Size(122, 28);
            this.radioButtonSearchName.TabIndex = 47;
            this.radioButtonSearchName.TabStop = true;
            this.radioButtonSearchName.Text = "First Name";
            this.radioButtonSearchName.UseVisualStyleBackColor = true;
            // 
            // labelSearchby
            // 
            this.labelSearchby.AutoSize = true;
            this.labelSearchby.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchby.Location = new System.Drawing.Point(464, 57);
            this.labelSearchby.Name = "labelSearchby";
            this.labelSearchby.Size = new System.Drawing.Size(105, 24);
            this.labelSearchby.TabIndex = 46;
            this.labelSearchby.Text = "Search by :";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonReset.Location = new System.Drawing.Point(915, 490);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(182, 37);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(57, 102);
            this.dataGridViewStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.ReadOnly = true;
            this.dataGridViewStudent.RowHeadersWidth = 51;
            this.dataGridViewStudent.RowTemplate.Height = 28;
            this.dataGridViewStudent.ShowEditingIcon = false;
            this.dataGridViewStudent.Size = new System.Drawing.Size(1040, 383);
            this.dataGridViewStudent.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSearch.Location = new System.Drawing.Point(915, 12);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(182, 37);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBoxTab
            // 
            this.groupBoxTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxTab.Controls.Add(this.radioButtonSearchEmail);
            this.groupBoxTab.Controls.Add(this.radioButtonSearchName);
            this.groupBoxTab.Controls.Add(this.labelSearchby);
            this.groupBoxTab.Controls.Add(this.buttonReset);
            this.groupBoxTab.Controls.Add(this.dataGridViewStudent);
            this.groupBoxTab.Controls.Add(this.buttonSearch);
            this.groupBoxTab.Controls.Add(this.textBoxSearch);
            this.groupBoxTab.Controls.Add(this.listBoxDetails);
            this.groupBoxTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTab.Location = new System.Drawing.Point(500, 206);
            this.groupBoxTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTab.Name = "groupBoxTab";
            this.groupBoxTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTab.Size = new System.Drawing.Size(1124, 531);
            this.groupBoxTab.TabIndex = 46;
            this.groupBoxTab.TabStop = false;
            this.groupBoxTab.Text = "Courses";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(468, 11);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(425, 40);
            this.textBoxSearch.TabIndex = 2;
            // 
            // listBoxDetails
            // 
            this.listBoxDetails.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxDetails.FormattingEnabled = true;
            this.listBoxDetails.ItemHeight = 29;
            this.listBoxDetails.Location = new System.Drawing.Point(57, 53);
            this.listBoxDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxDetails.Name = "listBoxDetails";
            this.listBoxDetails.Size = new System.Drawing.Size(1017, 406);
            this.listBoxDetails.TabIndex = 0;
            this.listBoxDetails.SelectedIndexChanged += new System.EventHandler(this.listBoxDetails_SelectedIndexChanged);
            // 
            // labelStudentEmail
            // 
            this.labelStudentEmail.AutoSize = true;
            this.labelStudentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentEmail.Location = new System.Drawing.Point(1274, 50);
            this.labelStudentEmail.Name = "labelStudentEmail";
            this.labelStudentEmail.Size = new System.Drawing.Size(116, 29);
            this.labelStudentEmail.TabIndex = 52;
            this.labelStudentEmail.Text = "Message";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(495, 50);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(116, 29);
            this.labelMessage.TabIndex = 51;
            this.labelMessage.Text = "Message";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(1275, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 25);
            this.label12.TabIndex = 47;
            this.label12.Text = "Sign out";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // lblStudentDetails
            // 
            this.lblStudentDetails.AutoSize = true;
            this.lblStudentDetails.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentDetails.Location = new System.Drawing.Point(33, 178);
            this.lblStudentDetails.Name = "lblStudentDetails";
            this.lblStudentDetails.Size = new System.Drawing.Size(250, 38);
            this.lblStudentDetails.TabIndex = 41;
            this.lblStudentDetails.Text = "Student Details";
            this.lblStudentDetails.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourses.Location = new System.Drawing.Point(33, 122);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(146, 38);
            this.lblCourses.TabIndex = 40;
            this.lblCourses.Text = "Courses";
            this.lblCourses.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblMyAccount
            // 
            this.lblMyAccount.AutoSize = true;
            this.lblMyAccount.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyAccount.Location = new System.Drawing.Point(33, 73);
            this.lblMyAccount.Name = "lblMyAccount";
            this.lblMyAccount.Size = new System.Drawing.Size(202, 38);
            this.lblMyAccount.TabIndex = 38;
            this.lblMyAccount.Text = "My Account";
            this.lblMyAccount.Click += new System.EventHandler(this.label2_Click);
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.fAQToolStripMenuItem.Text = "FAQ";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.contactUsToolStripMenuItem.Text = "Contact us";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactUsToolStripMenuItem,
            this.fAQToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // ourAchivementsToolStripMenuItem
            // 
            this.ourAchivementsToolStripMenuItem.Name = "ourAchivementsToolStripMenuItem";
            this.ourAchivementsToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.ourAchivementsToolStripMenuItem.Text = "Our Achivements";
            // 
            // ourFacilitiesToolStripMenuItem
            // 
            this.ourFacilitiesToolStripMenuItem.Name = "ourFacilitiesToolStripMenuItem";
            this.ourFacilitiesToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.ourFacilitiesToolStripMenuItem.Text = "Our Facilities";
            // 
            // aboutEToolStripMenuItem
            // 
            this.aboutEToolStripMenuItem.Name = "aboutEToolStripMenuItem";
            this.aboutEToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.aboutEToolStripMenuItem.Text = "About ESOFT_STMS";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutEToolStripMenuItem,
            this.ourFacilitiesToolStripMenuItem,
            this.ourAchivementsToolStripMenuItem});
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.aboutUsToolStripMenuItem.Text = "About us";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Shaping Lives, Creating Futures";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1635, 28);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.labelTeacherDetails);
            this.groupBox2.Controls.Add(this.lblStudentDetails);
            this.groupBox2.Controls.Add(this.lblCourses);
            this.groupBox2.Controls.Add(this.lblMyAccount);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(15, 206);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(452, 531);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // labelTeacherDetails
            // 
            this.labelTeacherDetails.AutoSize = true;
            this.labelTeacherDetails.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeacherDetails.Location = new System.Drawing.Point(30, 233);
            this.labelTeacherDetails.Name = "labelTeacherDetails";
            this.labelTeacherDetails.Size = new System.Drawing.Size(260, 38);
            this.labelTeacherDetails.TabIndex = 42;
            this.labelTeacherDetails.Text = "Teacher Details";
            this.labelTeacherDetails.Click += new System.EventHandler(this.labelTeacher_Click);
            // 
            // formAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1635, 740);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.groupBoxTab);
            this.Controls.Add(this.labelStudentEmail);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.groupBoxTab.ResumeLayout(false);
            this.groupBoxTab.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.RadioButton radioButtonSearchEmail;
        private System.Windows.Forms.RadioButton radioButtonSearchName;
        private System.Windows.Forms.Label labelSearchby;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBoxTab;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ListBox listBoxDetails;
        private System.Windows.Forms.Label labelStudentEmail;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblStudentDetails;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.Label lblMyAccount;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ourAchivementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ourFacilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelTeacherDetails;
    }
}