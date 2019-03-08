using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDMC
{
    public partial class ManageStudentsScreen : Form
    {
        public ManageStudentsScreen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            this.Hide();
            addStudent.Show();
        }

        private void ManageStudentsScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dMCDataSet1.StudentData' table. You can move, or remove it, as needed.
            this.studentDataTableAdapter1.Fill(this.dMCDataSet1.StudentData);
           
          

        }
        public int selected;
        private void StudentsdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = StudentsdataGridView.CurrentCell.RowIndex;
            DataGridViewRow row = StudentsdataGridView.Rows[selected];
            string searchStudent = String.Format("select * from CourseDMC where StudentId='{0}'", row.Cells[0].Value);
            var allCourses = DataBaseConnection.getInstance().readData(searchStudent);
            Student s = new Student();
            s.RegisterationNumber1 = row.Cells[0].Value.ToString();
            s.Name1 = row.Cells[1].Value.ToString();
            s.Degree1 = row.Cells[2].Value.ToString().Trim();
                while (allCourses.Read())
                {
                    CourseResult result = new CourseResult();
                    result.CourseId1 = allCourses.GetString(0).Trim();
                    result.CourseTitle1 = allCourses.GetString(1);
                    result.CreditHours1 = (int)allCourses.GetValue(2);
                    result.Marks1 = (int)allCourses.GetValue(3);
                    result.Semester1 = (int)allCourses.GetValue(4);
                    s.Courses2.Add(result);
               }
             Section.getInstance().addStudent(s);
             if (e.ColumnIndex == 4)
             {
                 AddStudent editStudent = new AddStudent();
                 this.Hide();
                 editStudent.Show();

            }
            if (e.ColumnIndex == 5)
            {
                ShowDMC dmc = new ShowDMC();
                dmc.Show();
            }

        }
    }
}
