namespace Final_Project___ESOFT
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.labelTeacher = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.groupBoxTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Final_Project___ESOFT.Properties.Resources.Logo;
            this.pbLogo.Location = new System.Drawing.Point(12, 63);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(335, 122);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 49;
            this.pbLogo.TabStop = false;
            // 
            // radioButtonSearchEmail
            // 
            this.radioButtonSearchEmail.AutoSize = true;
            this.radioButtonSearchEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSearchEmail.Location = new System.Drawing.Point(851, 71);
            this.radioButtonSearchEmail.Name = "radioButtonSearchEmail";
            this.radioButtonSearchEmail.Size = new System.Drawing.Size(93, 30);
            this.radioButtonSearchEmail.TabIndex = 48;
            this.radioButtonSearchEmail.Text = "Email";
            this.radioButtonSearchEmail.UseVisualStyleBackColor = true;
            // 
            // radioButtonSearchName
            // 
            this.radioButtonSearchName.AutoSize = true;
            this.radioButtonSearchName.Checked = true;
            this.radioButtonSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSearchName.Location = new System.Drawing.Point(672, 71);
            this.radioButtonSearchName.Name = "radioButtonSearchName";
            this.radioButtonSearchName.Size = new System.Drawing.Size(144, 30);
            this.radioButtonSearchName.TabIndex = 47;
            this.radioButtonSearchName.TabStop = true;
            this.radioButtonSearchName.Text = "First Name";
            this.radioButtonSearchName.UseVisualStyleBackColor = true;
            // 
            // labelSearchby
            // 
            this.labelSearchby.AutoSize = true;
            this.labelSearchby.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchby.Location = new System.Drawing.Point(522, 71);
            this.labelSearchby.Name = "labelSearchby";
            this.labelSearchby.Size = new System.Drawing.Size(122, 26);
            this.labelSearchby.TabIndex = 46;
            this.labelSearchby.Text = "Search by :";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonReset.Location = new System.Drawing.Point(1029, 612);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(205, 46);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(64, 127);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.ReadOnly = true;
            this.dataGridViewStudent.RowTemplate.Height = 28;
            this.dataGridViewStudent.ShowEditingIcon = false;
            this.dataGridViewStudent.Size = new System.Drawing.Size(1170, 479);
            this.dataGridViewStudent.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSearch.Location = new System.Drawing.Point(1029, 15);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(205, 46);
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
            this.groupBoxTab.Location = new System.Drawing.Point(563, 258);
            this.groupBoxTab.Name = "groupBoxTab";
            this.groupBoxTab.Size = new System.Drawing.Size(1264, 664);
            this.groupBoxTab.TabIndex = 46;
            this.groupBoxTab.TabStop = false;
            this.groupBoxTab.Text = "Courses";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(527, 14);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(478, 46);
            this.textBoxSearch.TabIndex = 2;
            // 
            // listBoxDetails
            // 
            this.listBoxDetails.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxDetails.FormattingEnabled = true;
            this.listBoxDetails.ItemHeight = 36;
            this.listBoxDetails.Location = new System.Drawing.Point(64, 66);
            this.listBoxDetails.Name = "listBoxDetails";
            this.listBoxDetails.Size = new System.Drawing.Size(1144, 540);
            this.listBoxDetails.TabIndex = 0;
            this.listBoxDetails.SelectedIndexChanged += new System.EventHandler(this.listBoxDetails_SelectedIndexChanged);
            // 
            // labelStudentEmail
            // 
            this.labelStudentEmail.AutoSize = true;
            this.labelStudentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentEmail.Location = new System.Drawing.Point(1433, 63);
            this.labelStudentEmail.Name = "labelStudentEmail";
            this.labelStudentEmail.Size = new System.Drawing.Size(135, 36);
            this.labelStudentEmail.TabIndex = 52;
            this.labelStudentEmail.Text = "Message";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(557, 63);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(135, 36);
            this.labelMessage.TabIndex = 51;
            this.labelMessage.Text = "Message";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(1434, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 29);
            this.label12.TabIndex = 47;
            this.label12.Text = "Sign out";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 46);
            this.label5.TabIndex = 41;
            this.label5.Text = "Student Details";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 46);
            this.label4.TabIndex = 40;
            this.label4.Text = "Courses";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 46);
            this.label2.TabIndex = 38;
            this.label2.Text = "My Account";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(168, 30);
            this.fAQToolStripMenuItem.Text = "FAQ";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(168, 30);
            this.contactUsToolStripMenuItem.Text = "Contact us";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactUsToolStripMenuItem,
            this.fAQToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // ourAchivementsToolStripMenuItem
            // 
            this.ourAchivementsToolStripMenuItem.Name = "ourAchivementsToolStripMenuItem";
            this.ourAchivementsToolStripMenuItem.Size = new System.Drawing.Size(220, 30);
            this.ourAchivementsToolStripMenuItem.Text = "Our Achivements";
            // 
            // ourFacilitiesToolStripMenuItem
            // 
            this.ourFacilitiesToolStripMenuItem.Name = "ourFacilitiesToolStripMenuItem";
            this.ourFacilitiesToolStripMenuItem.Size = new System.Drawing.Size(220, 30);
            this.ourFacilitiesToolStripMenuItem.Text = "Our Facilities";
            // 
            // aboutEToolStripMenuItem
            // 
            this.aboutEToolStripMenuItem.Name = "aboutEToolStripMenuItem";
            this.aboutEToolStripMenuItem.Size = new System.Drawing.Size(220, 30);
            this.aboutEToolStripMenuItem.Text = "About ESOFT";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutEToolStripMenuItem,
            this.ourFacilitiesToolStripMenuItem,
            this.ourAchivementsToolStripMenuItem});
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.aboutUsToolStripMenuItem.Text = "About us";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Shaping Lives, Creating Futures";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1839, 33);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.labelTeacher);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(17, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 664);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeacher.Location = new System.Drawing.Point(34, 291);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(308, 46);
            this.labelTeacher.TabIndex = 42;
            this.labelTeacher.Text = "Teacher Details";
            this.labelTeacher.Click += new System.EventHandler(this.labelTeacher_Click);
            // 
            // formAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1839, 925);
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
            this.Name = "formAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Label labelTeacher;
    }
}