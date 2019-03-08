namespace StudentDMC
{
    partial class ManageStudentsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStudentsScreen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblStudentText = new System.Windows.Forms.Label();
            this.picBoxAddStudent = new System.Windows.Forms.PictureBox();
            this.StudentsdataGridView = new System.Windows.Forms.DataGridView();
            this.studentDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dMCDataSet = new StudentDMC.DMCDataSet();
            this.studentDataTableAdapter = new StudentDMC.DMCDataSetTableAdapters.StudentDataTableAdapter();
            this.dMCDataSet1 = new StudentDMC.DMCDataSet1();
            this.studentDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataTableAdapter1 = new StudentDMC.DMCDataSet1TableAdapters.StudentDataTableAdapter();
            this.regNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAddStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMCDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentText
            // 
            this.lblStudentText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStudentText.AutoSize = true;
            this.lblStudentText.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentText.Location = new System.Drawing.Point(33, 37);
            this.lblStudentText.Name = "lblStudentText";
            this.lblStudentText.Size = new System.Drawing.Size(93, 22);
            this.lblStudentText.TabIndex = 0;
            this.lblStudentText.Text = "Students";
            // 
            // picBoxAddStudent
            // 
            this.picBoxAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAddStudent.Image")));
            this.picBoxAddStudent.Location = new System.Drawing.Point(150, 37);
            this.picBoxAddStudent.Name = "picBoxAddStudent";
            this.picBoxAddStudent.Size = new System.Drawing.Size(24, 24);
            this.picBoxAddStudent.TabIndex = 1;
            this.picBoxAddStudent.TabStop = false;
            this.picBoxAddStudent.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // StudentsdataGridView
            // 
            this.StudentsdataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.StudentsdataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentsdataGridView.AutoGenerateColumns = false;
            this.StudentsdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentsdataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.StudentsdataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentsdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StudentsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.degreeDataGridViewTextBoxColumn,
            this.coursesDataGridViewTextBoxColumn,
            this.Actions,
            this.Column1});
            this.StudentsdataGridView.DataSource = this.studentDataBindingSource1;
            this.StudentsdataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StudentsdataGridView.Location = new System.Drawing.Point(0, 120);
            this.StudentsdataGridView.MultiSelect = false;
            this.StudentsdataGridView.Name = "StudentsdataGridView";
            this.StudentsdataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentsdataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.StudentsdataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StudentsdataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.StudentsdataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentsdataGridView.Size = new System.Drawing.Size(584, 291);
            this.StudentsdataGridView.TabIndex = 2;
            this.StudentsdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsdataGridView_CellContentClick);
            // 
            // studentDataBindingSource
            // 
            this.studentDataBindingSource.DataMember = "StudentData";
            this.studentDataBindingSource.DataSource = this.dMCDataSet;
            // 
            // dMCDataSet
            // 
            this.dMCDataSet.DataSetName = "DMCDataSet";
            this.dMCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDataTableAdapter
            // 
            this.studentDataTableAdapter.ClearBeforeFill = true;
            // 
            // dMCDataSet1
            // 
            this.dMCDataSet1.DataSetName = "DMCDataSet1";
            this.dMCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDataBindingSource1
            // 
            this.studentDataBindingSource1.DataMember = "StudentData";
            this.studentDataBindingSource1.DataSource = this.dMCDataSet1;
            // 
            // studentDataTableAdapter1
            // 
            this.studentDataTableAdapter1.ClearBeforeFill = true;
            // 
            // regNoDataGridViewTextBoxColumn
            // 
            this.regNoDataGridViewTextBoxColumn.DataPropertyName = "RegNo";
            this.regNoDataGridViewTextBoxColumn.HeaderText = "RegNo";
            this.regNoDataGridViewTextBoxColumn.Name = "regNoDataGridViewTextBoxColumn";
            this.regNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // degreeDataGridViewTextBoxColumn
            // 
            this.degreeDataGridViewTextBoxColumn.DataPropertyName = "Degree";
            this.degreeDataGridViewTextBoxColumn.HeaderText = "Degree";
            this.degreeDataGridViewTextBoxColumn.Name = "degreeDataGridViewTextBoxColumn";
            this.degreeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coursesDataGridViewTextBoxColumn
            // 
            this.coursesDataGridViewTextBoxColumn.DataPropertyName = "Courses";
            this.coursesDataGridViewTextBoxColumn.HeaderText = "Courses";
            this.coursesDataGridViewTextBoxColumn.Name = "coursesDataGridViewTextBoxColumn";
            this.coursesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Actions
            // 
            this.Actions.HeaderText = "Edit";
            this.Actions.Name = "Actions";
            this.Actions.ReadOnly = true;
            this.Actions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Actions.Text = "Edit";
            this.Actions.UseColumnTextForButtonValue = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ShowDMC";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "ShowDMC";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // ManageStudentsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.StudentsdataGridView);
            this.Controls.Add(this.picBoxAddStudent);
            this.Controls.Add(this.lblStudentText);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "ManageStudentsScreen";
            this.Text = "Manage Students";
            this.Load += new System.EventHandler(this.ManageStudentsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAddStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMCDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentText;
        private System.Windows.Forms.PictureBox picBoxAddStudent;
        private System.Windows.Forms.DataGridView StudentsdataGridView;
        private DMCDataSet dMCDataSet;
        private System.Windows.Forms.BindingSource studentDataBindingSource;
        private DMCDataSetTableAdapters.StudentDataTableAdapter studentDataTableAdapter;
        private DMCDataSet1 dMCDataSet1;
        private System.Windows.Forms.BindingSource studentDataBindingSource1;
        private DMCDataSet1TableAdapters.StudentDataTableAdapter studentDataTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn regNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Actions;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}