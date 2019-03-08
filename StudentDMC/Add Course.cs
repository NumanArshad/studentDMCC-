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
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }
        bool isEditeMode = false;
        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (this.validateCourses())
            {
                if (isEditeMode)
                {
                    foreach (CourseResult find in Section.getInstance().ListofStudents().Last().Courses2)
                    {
                        if (find.CourseId1 == Section.getInstance().ListofStudents().ElementAt(secondaLast).Courses2.Last().CourseId1 &&
                            find.CourseTitle1 == Section.getInstance().ListofStudents().ElementAt(secondaLast).Courses2.Last().CourseTitle1 &&
                            find.CreditHours1 == Section.getInstance().ListofStudents().ElementAt(secondaLast).Courses2.Last().CreditHours1 &&
                            find.Semester1 == Section.getInstance().ListofStudents().ElementAt(secondaLast).Courses2.Last().Semester1 &&
                            find.Marks1 == Section.getInstance().ListofStudents().ElementAt(secondaLast).Courses2.Last().Marks1)
                        {
                            find.CourseId1 = txtBxCourseId.Text;
                            find.CourseTitle1 = txtCourseTitle.Text;
                            find.CreditHours1 = int.Parse(cmbCreditHour.Text);
                            find.Semester1 = int.Parse(cmbSemester.Text);
                            find.Marks1 = int.Parse(txtMarks.Text);
                            break;
                        }
                    }
                  
                }
                else
                {
                 
                    CourseResult result = new CourseResult();
                    result.CourseId1 = txtBxCourseId.Text;
                    result.CourseTitle1 = txtCourseTitle.Text;
                    result.CreditHours1 = int.Parse(cmbCreditHour.Text);
                    result.Semester1 = int.Parse(cmbSemester.Text);
                    result.Marks1 = int.Parse(txtMarks.Text);
                    Section.getInstance().ListofStudents().Last().Courses2.Add(result);
                }

                AddStudent addStudent = new AddStudent();
                this.Hide();
                addStudent.Show();
            }
        }

        public bool validateCourses()
        {
            CourseResult obj = new CourseResult();
            bool isvalid = false;
            lblCourseIdError.Text= "";lblCourseNameError.Text = ""; lblCHError.Text="";lblSemesterError.Text="" ; lblMarksError.Text = "";
            bool isinvalidCourseId = false, isinvalidCourseName = false, isinvalidCH = false, isinvalidSemester = false,isinvalidMarks = false;
            if (obj.invalidCourseId(txtBxCourseId.Text))
            {
                lblCourseIdError.Text = "Invalid CourseId";
                isinvalidCourseId = true;

            }
            if (obj.invalidCourseTitle(txtCourseTitle.Text))
            {
                lblCourseNameError.Text = "Invalid CourseName";
                isinvalidCourseName = true;
            }

            if (obj.invalidCreditHour(int.Parse(cmbCreditHour.Text))){
                lblCHError.Text = "Invalid Credit Hour";
                isinvalidCH = true;
            }
            if (obj.invalidSemester(int.Parse(cmbSemester.Text)))
            {
                lblSemesterError.Text = "Invalid Semester";
                isinvalidSemester = true;
            }

            if (obj.invalidMarks(int.Parse(txtMarks.Text))){
                lblMarksError.Text = "Invalid Marks";
                isinvalidMarks = true;
            }
            else
            {
                bool isexist = false; lblalreadyExist.Text = "";
                if(!isinvalidCourseId && !isinvalidCourseName && !isinvalidCH && !isinvalidSemester && !isinvalidMarks)
                {
                    foreach(CourseResult resultbj in Section.getInstance().ListofStudents().Last().Courses2)
                    {
                        if(resultbj.CourseId1==txtBxCourseId.Text && resultbj.CourseTitle1 == txtCourseTitle.Text)
                        {
                            isexist = true;
                            break;
                        }
                    }
                    if (isexist)
                    {
                        lblalreadyExist.Text = "Course already Exist in student result";
                    }
                    else
                    {
                        isvalid = true;
                    }


                    
                }
            }
            return isvalid;



        }
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            this.Hide();
            addStudent.Show();
        }
        int secondaLast = 0;
        private void AddCourse_Load(object sender, EventArgs e)
        {
            txtBxCourseId.Text = "";
            txtCourseTitle.Text = "";
            txtMarks.Text = "";
         if (Section.getInstance().ListofStudents().Count() > 1)
            {
                
                isEditeMode = true;

                txtBxCourseId.Text = Section.getInstance().ListofStudents().ElementAt(secondaLast).Courses2.Last().CourseId1;
                txtCourseTitle.Text = Section.getInstance().ListofStudents().ElementAt(secondaLast).Courses2.Last().CourseTitle1;
                cmbCreditHour.Text = Section.getInstance().ListofStudents().ElementAt(secondaLast).Courses2.Last().CreditHours1.ToString();
                cmbSemester.Text = Section.getInstance().ListofStudents().ElementAt(secondaLast).Courses2.Last().Semester1.ToString();
                txtMarks.Text = Section.getInstance().ListofStudents().ElementAt(secondaLast).Courses2.Last().Marks1.ToString();
            }

        }
    }
}
