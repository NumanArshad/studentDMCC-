using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDMC
{
    /// <summary>
    /// courseResult class to implement the result detail of a student result
    /// </summary>
    class CourseResult
    {
        private string CourseId;
        private string CourseTitle;
        private int CreditHours;
        private int Marks;
        private int Semester;
        /// <summary>
        ///getter and setter for class data member
        /// </summary>
        public string CourseId1
        {
            get
            {
                return CourseId;
            }

            set
            {
                if (!invalidCourseId(value))
               {
                    CourseId = value;
                }
               
            }
        }

        public string CourseTitle1
        {
            get
            {
                return CourseTitle;
            }

            set
            {
                if (!invalidCourseTitle(value))
                {
                    CourseTitle = value;
                }
               
            }
        }

        public int CreditHours1
        {
            get
            {
                return CreditHours;
            }

            set
            {
                if (!invalidCreditHour(value))
                {
                    CreditHours = value;
                }

            }
        }

        public int Marks1
        {
            get
            {
                return Marks;
            }

            set
            {
                if (!invalidMarks(value))
                {
                    Marks = value;
                }

            }
        }

        public int Semester1
        {
            get
            {
                return Semester;
            }

            set
            {
                  if (!invalidSemester(value))
                  {
                Semester = value;
                 }

            }
        }
        /// <summary>
        /// validate course id
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns>boolean</returns>
        public  bool invalidCourseId(string courseId)
        {
            bool isInavlid = false;
            if(courseId.Count()<2 || courseId.Count() > 8)
            {
                isInavlid = true;
            }
            return isInavlid;

        }
        /// <summary>
        /// validate courseTitle
        /// </summary>
        /// <param name="courseTitle"></param>
        /// <returns>boolean</returns>
        public bool invalidCourseTitle(string courseTitle)
        {
            bool isInvalid = false;
            if(courseTitle.Any(Char.IsDigit) || courseTitle == "" || courseTitle.Count()<10 || courseTitle.Count() > 35 )
            {
                isInvalid = true;
            }
            return isInvalid;
        }
        /// <summary>
        /// validate credit hour 
        /// </summary>
        /// <param name="creditHour"></param>
        /// <returns>boolean</returns>
        public bool invalidCreditHour(int creditHour)
        {
            bool isInvalid = false;
            if(creditHour<1 || creditHour > 3)
            {
                isInvalid = true;
            }
            return isInvalid;
        }
        /// <summary>
        /// validate marks of student in course
        /// </summary>
        /// <param name="marks"></param>
        /// <returns>boolean</returns>
        public bool invalidMarks(int marks)
        {
            bool isInvalid = false;
            if(marks<0 || marks > 100 || marks.ToString()=="")
            {
                isInvalid=true;
            }
            return isInvalid;
        }
        /// <summary>
        /// validate semester
        /// </summary>
        /// <param name="semester"></param>
        /// <returns>boolean</returns>
        public bool invalidSemester(int semester)
        {
            bool isInvalid = false;
            if(semester<1 || semester > 8)
            {
                isInvalid = true;
            }
            return isInvalid;
        }
        /// <summary>
        /// validate grade in course
        /// </summary>
        /// <returns>string grade</returns>
        public string getGrade()
        {
            string grade = null;
            if (Marks < 40)
            {
                grade="F";
            }
            if(Marks >= 40 && Marks < 50)
            {
                grade="D";
            }
            if(Marks >= 50 && Marks < 55)
            {
                grade="C";
            }
            if(Marks >= 55  && Marks < 60)
            {
                grade="C+";
            }
            if(Marks >= 60 && Marks < 65)
            {
                grade= "B-";
            }
            if (Marks >= 65 && Marks < 70)
            {
                grade= "B+";
            }
            if (Marks >= 70 && Marks <= 80)
            {
                grade= "A-";
            }
            if (Marks > 80)
            {
                grade= "A";
            }
            return grade;
        }
        /// <summary>
        /// default constrcutor
        /// </summary>
        public CourseResult()
        {
           


        }
        /// <summary>
        /// parametric constuctor
        /// </summary>
        /// <param name="courseId"></param>
        /// <param name="courseTitle"></param>
        /// <param name="marks"></param>
        /// <param name="semester"></param>
        /// <param name="creditHour"></param>
        public CourseResult(string courseId,string courseTitle,int marks,int semester,int creditHour)
        {
            this.CourseId = courseId;
            this.CourseTitle = courseTitle;
            this.Marks = marks;
            this.Semester = semester;
            this.CreditHours = creditHour;
        }
        /// <summary>
        /// copy constructor 
        /// </summary>
        /// <param name="resultObj"></param>
        public CourseResult(CourseResult resultObj)
        {
            CourseId = resultObj.CourseId1;
            CourseTitle = resultObj.CourseTitle1;
            Marks = resultObj.Marks1;
            Semester = resultObj.Semester1;
            CreditHours = resultObj.CreditHours1;
        }
        /// <summary>
        /// function to get gradepoint of specific course 
        /// </summary>
        /// <returns>double gradePoint</returns>
        public double getGradePoints()
        {
       
            double gradePoint = 0.0;
            switch (getGrade())
            {
                case "A": gradePoint=4.0;break;
                case "A-": gradePoint=3.7; break;
                case "B+": gradePoint=3.3; break;
                case "B-": gradePoint= 3.0; break;
                case "C+": gradePoint= 2.7; break;
                case "C": gradePoint= 2.3; break;
                case "D": gradePoint= 1.0; break;
                default: gradePoint= 0.0; break;
            }
            return gradePoint;
        }
        /// <summary>
        /// function to get string of all attributes in specific format
        /// </summary>
        /// <returns></returns>
        public string toString()
        {
           return string.Format("course Id:{0} \n courseTitle{1} \n credithourse:{2} \n marks:{3} \n semester:{4}", CourseId, CourseTitle, CreditHours, Marks, Semester);

        }
          

       
    }
}
