namespace StudentDMC
{
    partial class AddCourse
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
            this.lblCourseId = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCH = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblObtainMarks = new System.Windows.Forms.Label();
            this.txtBxCourseId = new System.Windows.Forms.TextBox();
            this.txtCourseTitle = new System.Windows.Forms.TextBox();
            this.cmbCreditHour = new System.Windows.Forms.ComboBox();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.lblCourseIdError = new System.Windows.Forms.Label();
            this.lblCourseNameError = new System.Windows.Forms.Label();
            this.lblCHError = new System.Windows.Forms.Label();
            this.lblSemesterError = new System.Windows.Forms.Label();
            this.lblMarksError = new System.Windows.Forms.Label();
            this.lblalreadyExist = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCourseId
            // 
            this.lblCourseId.AutoSize = true;
            this.lblCourseId.Location = new System.Drawing.Point(33, 26);
            this.lblCourseId.Name = "lblCourseId";
            this.lblCourseId.Size = new System.Drawing.Size(54, 13);
            this.lblCourseId.TabIndex = 0;
            this.lblCourseId.Text = "Course ID";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(33, 64);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(35, 13);
            this.lblCourseName.TabIndex = 0;
            this.lblCourseName.Text = "Name";
            // 
            // lblCH
            // 
            this.lblCH.AutoSize = true;
            this.lblCH.Location = new System.Drawing.Point(33, 100);
            this.lblCH.Name = "lblCH";
            this.lblCH.Size = new System.Drawing.Size(65, 13);
            this.lblCH.TabIndex = 0;
            this.lblCH.Text = "Credit Hours";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(33, 141);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(51, 13);
            this.lblSemester.TabIndex = 0;
            this.lblSemester.Text = "Semester";
            // 
            // lblObtainMarks
            // 
            this.lblObtainMarks.AutoSize = true;
            this.lblObtainMarks.Location = new System.Drawing.Point(33, 189);
            this.lblObtainMarks.Name = "lblObtainMarks";
            this.lblObtainMarks.Size = new System.Drawing.Size(36, 13);
            this.lblObtainMarks.TabIndex = 0;
            this.lblObtainMarks.Text = "Marks";
            // 
            // txtBxCourseId
            // 
            this.txtBxCourseId.Location = new System.Drawing.Point(159, 23);
            this.txtBxCourseId.Name = "txtBxCourseId";
            this.txtBxCourseId.Size = new System.Drawing.Size(100, 20);
            this.txtBxCourseId.TabIndex = 1;
            // 
            // txtCourseTitle
            // 
            this.txtCourseTitle.Location = new System.Drawing.Point(159, 61);
            this.txtCourseTitle.Name = "txtCourseTitle";
            this.txtCourseTitle.Size = new System.Drawing.Size(100, 20);
            this.txtCourseTitle.TabIndex = 1;
            // 
            // cmbCreditHour
            // 
            this.cmbCreditHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCreditHour.FormattingEnabled = true;
            this.cmbCreditHour.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbCreditHour.Location = new System.Drawing.Point(159, 97);
            this.cmbCreditHour.Name = "cmbCreditHour";
            this.cmbCreditHour.Size = new System.Drawing.Size(100, 21);
            this.cmbCreditHour.TabIndex = 2;
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(159, 186);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(100, 20);
            this.txtMarks.TabIndex = 1;
            // 
            // cmbSemester
            // 
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbSemester.Location = new System.Drawing.Point(159, 138);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(100, 21);
            this.cmbSemester.TabIndex = 2;
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.Color.Black;
            this.cmdCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdCancel.Location = new System.Drawing.Point(50, 226);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.Color.Black;
            this.cmdSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdSave.Location = new System.Drawing.Point(184, 226);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 3;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // lblCourseIdError
            // 
            this.lblCourseIdError.AutoSize = true;
            this.lblCourseIdError.ForeColor = System.Drawing.Color.Red;
            this.lblCourseIdError.Location = new System.Drawing.Point(299, 26);
            this.lblCourseIdError.Name = "lblCourseIdError";
            this.lblCourseIdError.Size = new System.Drawing.Size(0, 13);
            this.lblCourseIdError.TabIndex = 4;
            // 
            // lblCourseNameError
            // 
            this.lblCourseNameError.AutoSize = true;
            this.lblCourseNameError.ForeColor = System.Drawing.Color.Red;
            this.lblCourseNameError.Location = new System.Drawing.Point(299, 64);
            this.lblCourseNameError.Name = "lblCourseNameError";
            this.lblCourseNameError.Size = new System.Drawing.Size(0, 13);
            this.lblCourseNameError.TabIndex = 4;
            // 
            // lblCHError
            // 
            this.lblCHError.AutoSize = true;
            this.lblCHError.ForeColor = System.Drawing.Color.Red;
            this.lblCHError.Location = new System.Drawing.Point(299, 100);
            this.lblCHError.Name = "lblCHError";
            this.lblCHError.Size = new System.Drawing.Size(0, 13);
            this.lblCHError.TabIndex = 4;
            // 
            // lblSemesterError
            // 
            this.lblSemesterError.AutoSize = true;
            this.lblSemesterError.ForeColor = System.Drawing.Color.Red;
            this.lblSemesterError.Location = new System.Drawing.Point(299, 141);
            this.lblSemesterError.Name = "lblSemesterError";
            this.lblSemesterError.Size = new System.Drawing.Size(0, 13);
            this.lblSemesterError.TabIndex = 4;
            // 
            // lblMarksError
            // 
            this.lblMarksError.AutoSize = true;
            this.lblMarksError.ForeColor = System.Drawing.Color.Red;
            this.lblMarksError.Location = new System.Drawing.Point(299, 189);
            this.lblMarksError.Name = "lblMarksError";
            this.lblMarksError.Size = new System.Drawing.Size(0, 13);
            this.lblMarksError.TabIndex = 4;
            // 
            // lblalreadyExist
            // 
            this.lblalreadyExist.AutoSize = true;
            this.lblalreadyExist.ForeColor = System.Drawing.Color.Red;
            this.lblalreadyExist.Location = new System.Drawing.Point(181, 9);
            this.lblalreadyExist.Name = "lblalreadyExist";
            this.lblalreadyExist.Size = new System.Drawing.Size(0, 13);
            this.lblalreadyExist.TabIndex = 5;
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(414, 311);
            this.Controls.Add(this.lblalreadyExist);
            this.Controls.Add(this.lblMarksError);
            this.Controls.Add(this.lblSemesterError);
            this.Controls.Add(this.lblCHError);
            this.Controls.Add(this.lblCourseNameError);
            this.Controls.Add(this.lblCourseIdError);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.cmbCreditHour);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.txtCourseTitle);
            this.Controls.Add(this.txtBxCourseId);
            this.Controls.Add(this.lblObtainMarks);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lblCH);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblCourseId);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 350);
            this.MinimumSize = new System.Drawing.Size(430, 350);
            this.Name = "AddCourse";
            this.Text = "Add Course";
            this.Load += new System.EventHandler(this.AddCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseId;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCH;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblObtainMarks;
        private System.Windows.Forms.TextBox txtBxCourseId;
        private System.Windows.Forms.TextBox txtCourseTitle;
        private System.Windows.Forms.ComboBox cmbCreditHour;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label lblCourseIdError;
        private System.Windows.Forms.Label lblCourseNameError;
        private System.Windows.Forms.Label lblCHError;
        private System.Windows.Forms.Label lblSemesterError;
        private System.Windows.Forms.Label lblMarksError;
        private System.Windows.Forms.Label lblalreadyExist;
    }
}