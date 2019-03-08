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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bool haveCourses = false;
            try
            {
                MessageBox.Show(Section.getInstance().ListofStudents().Last().Courses2.Count.ToString());
                if (Section.getInstance().ListofStudents().Last().Courses2.Count > 0)
                {
                    haveCourses = true;
               
                }
             }
            catch
            {
              //  MessageBox.Show("error is " + exp.ToString());
            }
            if (!haveCourses)
            {
              bool invalidName = false, invalidReg = false, invalidDegree = false;
                lblNameError.Text = ""; lblRegNoError.Text = ""; lblDegreeError.Text = "";
                Student obj = new Student();
                if (obj.invalidName(txtName.Text))
                {
                    lblNameError.Text = "Invalid Name";
                    invalidName = true;
                }
                if (obj.invalidRegisteration(txtRegNo.Text))
                {
                    lblRegNoError.Text = "Invalid Registeration Number";
                    invalidReg = true;
                }
                if (obj.invalidDegree(cmbBoxDegree.Text))
                {
                    lblDegreeError.Text = "Invalid Degree";
                    invalidDegree = true;
                }
                else
                {
                    if(!invalidName && !invalidReg && !invalidDegree)
                    {
                        obj.Name1 = txtName.Text;
                        obj.RegisterationNumber1 = txtRegNo.Text;
                        obj.Degree1 = cmbBoxDegree.Text;
                        Section sec = Section.getInstance();
                        sec.addStudent(obj);
                       if (Section.getInstance().ListofStudents().Count() > 1)
                        {
                        Section.getInstance().ListofStudents().RemoveAt(0);
                        }

                        AddCourse addCourse = new AddCourse();
                        this.Hide();
                        addCourse.Show();
                    }
                   
                }
         }

            else
            {
                if (Section.getInstance().ListofStudents().Count() > 1)
                {
                   
                    Section.getInstance().ListofStudents().RemoveAt(0);
                }

                AddCourse addCourse = new AddCourse();
                this.Hide();
                addCourse.Show();
            }
          
        }
      
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Student Remove in Section.getInstance().ListofStudents())
                {
                    Section.getInstance().ListofStudents().Remove(Remove);
                }
            }
            catch(Exception p)
            {
                MessageBox.Show("error is " + p.ToString());
            }

            ManageStudentsScreen manageStudent = new ManageStudentsScreen();
            this.Hide();
            manageStudent.Show();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            try
            {
        
                if (Section.getInstance().ListofStudents().Count > 0)
                {
                    txtName.Text = Section.getInstance().ListofStudents().Last().Name1;
                    txtRegNo.Text = Section.getInstance().ListofStudents().Last().RegisterationNumber1;
                    cmbBoxDegree.Text = Section.getInstance().ListofStudents().Last().Degree1;
                    MessageBox.Show(cmbBoxDegree.Text);
                    DataTable t = new DataTable();
                    BindingSource b = new BindingSource();
                    b.DataSource = Section.getInstance().ListofStudents().Last().Courses2;
                    CoursesdataGridView.DataSource = b;

                    txtName.Enabled = false;
                    txtRegNo.Enabled = false;
                    cmbBoxDegree.Enabled = false;

                }

            }
            catch (Exception exp)
            {
                MessageBox.Show("error is " + exp.ToString());
            }

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            bool invalidName = false, invalidReg = false, invalidDegree = false;
            lblNameError.Text = ""; lblRegNoError.Text = ""; lblDegreeError.Text = "";
            Student obj = new Student();
            if (obj.invalidName(txtName.Text))
            {
                lblNameError.Text = "Invalid Name";
                invalidName = true;
            }
            if (obj.invalidRegisteration(txtRegNo.Text))
            {
                lblRegNoError.Text = "Invalid Registeration Number";
                invalidReg = true;
            }
            if (obj.invalidDegree(cmbBoxDegree.Text))
            {
                lblDegreeError.Text = "Invalid Degree";
                invalidDegree = true;
            }
            else
            {
                if (!invalidName && !invalidReg && !invalidDegree &&
                    Section.getInstance().ListofStudents().Count() > 0 && Section.getInstance().ListofStudents().Last().Courses2.Count() > 0)
                {
                    Student addStudent = new Student();
                    addStudent.Name1 = Section.getInstance().ListofStudents().Last().Name1;
                    addStudent.RegisterationNumber1 = Section.getInstance().ListofStudents().Last().RegisterationNumber1;
                    addStudent.Degree1 = Section.getInstance().ListofStudents().Last().Degree1;
                    addStudent.Courses2 = Section.getInstance().ListofStudents().Last().Courses2;

                    string studentInfo = string.Format("delete StudentData where RegNo='{0}'", addStudent.RegisterationNumber1);
                    DataBaseConnection.getInstance().executeQuery(studentInfo);
                    string deleteResult = string.Format("delete CourseDMC where StudentId='{0}'", addStudent.RegisterationNumber1);
                    DataBaseConnection.getInstance().executeQuery(deleteResult);


                    lblstudentExist.Text = "";
                    string storeStudent = string.Format("insert into StudentData(RegNo,Name,Degree,Courses) values('{0}','{1}','{2}','{3}')", txtRegNo.Text, txtName.Text,
                            cmbBoxDegree.Text, addStudent.Courses2.Count());

                    DataBaseConnection.getInstance().executeQuery(storeStudent);
                  


                    foreach (CourseResult result in addStudent.Courses2)
                    {

                        string courseResult = string.Format("insert into CourseDMC(CourseId,CourseTitle,CreditHour,Marks,Semester,Grade,StudentId) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                               result.CourseId1, result.CourseTitle1, result.CreditHours1, result.Marks1, result.Semester1, result.getGrade(), addStudent.RegisterationNumber1);
                        DataBaseConnection.getInstance().executeQuery(courseResult);
                       
                    }



                    Section.getInstance().ListofStudents().RemoveRange(0, Section.getInstance().ListofStudents().Count());


                    ManageStudentsScreen studentScreen = new ManageStudentsScreen();
                    this.Hide();
                    studentScreen.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Student info or course Result");
                }
            }

  //   }
        }


        int selected;
        private void CoursesdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = CoursesdataGridView.CurrentCell.RowIndex;
            DataGridViewRow row = CoursesdataGridView.Rows[selected];
            CourseResult r = new CourseResult();
            r.CourseId1 = row.Cells[0].Value.ToString();
            r.CourseTitle1 = row.Cells[1].Value.ToString();
            r.CreditHours1 = (int)row.Cells[2].Value;
            r.Marks1 = (int)row.Cells[3].Value;
            r.Semester1 = (int)row.Cells[4].Value;
           
            if (e.ColumnIndex == 6)
            {
                Section.getInstance().ListofStudents().Last().Courses2.Remove(r);
                CoursesdataGridView.Rows.Remove(row);
            }
           else if (e.ColumnIndex == 5)
            {
                Student editStudent = new Student();
                editStudent.Courses2.Add(r);
                Section.getInstance().ListofStudents().Insert(0, editStudent);
                AddCourse course = new AddCourse();
                this.Hide();
                course.Show();
            }

        }
    }
}
