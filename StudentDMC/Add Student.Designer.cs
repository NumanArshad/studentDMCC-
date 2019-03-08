namespace StudentDMC
{
    partial class AddStudent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.lblCoursesText = new System.Windows.Forms.Label();
            this.picBoxAddCourses = new System.Windows.Forms.PictureBox();
            this.CoursesdataGridView = new System.Windows.Forms.DataGridView();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmbBoxDegree = new System.Windows.Forms.ComboBox();
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblRegNoError = new System.Windows.Forms.Label();
            this.lblDegreeError = new System.Windows.Forms.Label();
            this.lblstudentExist = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.courseId1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTitle1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditHours1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marks1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semester1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAddCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reg No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Degree";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(219, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtRegNo
            // 
            this.txtRegNo.Location = new System.Drawing.Point(219, 97);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(100, 20);
            this.txtRegNo.TabIndex = 1;
            // 
            // lblCoursesText
            // 
            this.lblCoursesText.AutoSize = true;
            this.lblCoursesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoursesText.Location = new System.Drawing.Point(111, 187);
            this.lblCoursesText.Name = "lblCoursesText";
            this.lblCoursesText.Size = new System.Drawing.Size(92, 25);
            this.lblCoursesText.TabIndex = 0;
            this.lblCoursesText.Text = "Courses";
            // 
            // picBoxAddCourses
            // 
            this.picBoxAddCourses.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAddCourses.Image")));
            this.picBoxAddCourses.Location = new System.Drawing.Point(219, 187);
            this.picBoxAddCourses.Name = "picBoxAddCourses";
            this.picBoxAddCourses.Size = new System.Drawing.Size(24, 24);
            this.picBoxAddCourses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxAddCourses.TabIndex = 2;
            this.picBoxAddCourses.TabStop = false;
            this.picBoxAddCourses.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CoursesdataGridView
            // 
            this.CoursesdataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.CoursesdataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CoursesdataGridView.AutoGenerateColumns = false;
            this.CoursesdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CoursesdataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.CoursesdataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CoursesdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CoursesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoursesdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseId1DataGridViewTextBoxColumn,
            this.courseTitle1DataGridViewTextBoxColumn,
            this.creditHours1DataGridViewTextBoxColumn,
            this.marks1DataGridViewTextBoxColumn,
            this.semester1DataGridViewTextBoxColumn,
            this.Column1,
            this.Column2});
            this.CoursesdataGridView.DataSource = this.courseResultBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CoursesdataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.CoursesdataGridView.Location = new System.Drawing.Point(-1, 228);
            this.CoursesdataGridView.Name = "CoursesdataGridView";
            this.CoursesdataGridView.RowHeadersVisible = false;
            this.CoursesdataGridView.Size = new System.Drawing.Size(585, 171);
            this.CoursesdataGridView.TabIndex = 3;
            this.CoursesdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CoursesdataGridView_CellContentClick);
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.Color.Black;
            this.cmdCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdCancel.Location = new System.Drawing.Point(168, 412);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.Color.Black;
            this.cmdSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdSave.Location = new System.Drawing.Point(318, 412);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 4;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmbBoxDegree
            // 
            this.cmbBoxDegree.FormattingEnabled = true;
            this.cmbBoxDegree.Items.AddRange(new object[] {
            "BS",
            "BE ",
            "MS"});
            this.cmbBoxDegree.Location = new System.Drawing.Point(219, 139);
            this.cmbBoxDegree.Name = "cmbBoxDegree";
            this.cmbBoxDegree.Size = new System.Drawing.Size(100, 21);
            this.cmbBoxDegree.TabIndex = 5;
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(354, 49);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(0, 13);
            this.lblNameError.TabIndex = 6;
            // 
            // lblRegNoError
            // 
            this.lblRegNoError.AutoSize = true;
            this.lblRegNoError.ForeColor = System.Drawing.Color.Red;
            this.lblRegNoError.Location = new System.Drawing.Point(357, 100);
            this.lblRegNoError.Name = "lblRegNoError";
            this.lblRegNoError.Size = new System.Drawing.Size(0, 13);
            this.lblRegNoError.TabIndex = 7;
            // 
            // lblDegreeError
            // 
            this.lblDegreeError.AutoSize = true;
            this.lblDegreeError.ForeColor = System.Drawing.Color.Red;
            this.lblDegreeError.Location = new System.Drawing.Point(360, 146);
            this.lblDegreeError.Name = "lblDegreeError";
            this.lblDegreeError.Size = new System.Drawing.Size(0, 13);
            this.lblDegreeError.TabIndex = 8;
            // 
            // lblstudentExist
            // 
            this.lblstudentExist.AutoSize = true;
            this.lblstudentExist.ForeColor = System.Drawing.Color.Red;
            this.lblstudentExist.Location = new System.Drawing.Point(235, 22);
            this.lblstudentExist.Name = "lblstudentExist";
            this.lblstudentExist.Size = new System.Drawing.Size(0, 13);
            this.lblstudentExist.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Edit";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Edit";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Delete";
            this.Column2.Name = "Column2";
            this.Column2.Text = "Delete";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // courseId1DataGridViewTextBoxColumn
            // 
            this.courseId1DataGridViewTextBoxColumn.DataPropertyName = "CourseId1";
            this.courseId1DataGridViewTextBoxColumn.HeaderText = "CourseId";
            this.courseId1DataGridViewTextBoxColumn.Name = "courseId1DataGridViewTextBoxColumn";
            // 
            // courseTitle1DataGridViewTextBoxColumn
            // 
            this.courseTitle1DataGridViewTextBoxColumn.DataPropertyName = "CourseTitle1";
            this.courseTitle1DataGridViewTextBoxColumn.HeaderText = "CourseTitle";
            this.courseTitle1DataGridViewTextBoxColumn.Name = "courseTitle1DataGridViewTextBoxColumn";
            // 
            // creditHours1DataGridViewTextBoxColumn
            // 
            this.creditHours1DataGridViewTextBoxColumn.DataPropertyName = "CreditHours1";
            this.creditHours1DataGridViewTextBoxColumn.HeaderText = "CreditHours";
            this.creditHours1DataGridViewTextBoxColumn.Name = "creditHours1DataGridViewTextBoxColumn";
            // 
            // marks1DataGridViewTextBoxColumn
            // 
            this.marks1DataGridViewTextBoxColumn.DataPropertyName = "Marks1";
            this.marks1DataGridViewTextBoxColumn.HeaderText = "Marks";
            this.marks1DataGridViewTextBoxColumn.Name = "marks1DataGridViewTextBoxColumn";
            // 
            // semester1DataGridViewTextBoxColumn
            // 
            this.semester1DataGridViewTextBoxColumn.DataPropertyName = "Semester1";
            this.semester1DataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semester1DataGridViewTextBoxColumn.Name = "semester1DataGridViewTextBoxColumn";
            // 
            // courseResultBindingSource
            // 
            this.courseResultBindingSource.DataSource = typeof(StudentDMC.CourseResult);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(584, 436);
            this.Controls.Add(this.lblstudentExist);
            this.Controls.Add(this.lblDegreeError);
            this.Controls.Add(this.lblRegNoError);
            this.Controls.Add(this.lblNameError);
            this.Controls.Add(this.cmbBoxDegree);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.CoursesdataGridView);
            this.Controls.Add(this.picBoxAddCourses);
            this.Controls.Add(this.txtRegNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCoursesText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(600, 475);
            this.MinimumSize = new System.Drawing.Size(600, 475);
            this.Name = "AddStudent";
            this.Text = "Add Student";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAddCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.Label lblCoursesText;
        private System.Windows.Forms.PictureBox picBoxAddCourses;
        private System.Windows.Forms.DataGridView CoursesdataGridView;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.ComboBox cmbBoxDegree;
        private System.Windows.Forms.BindingSource courseResultBindingSource;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label lblRegNoError;
        private System.Windows.Forms.Label lblDegreeError;
        private System.Windows.Forms.Label lblstudentExist;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseId1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTitle1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditHours1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marks1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semester1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
    }
}