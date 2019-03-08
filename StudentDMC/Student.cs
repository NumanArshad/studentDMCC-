using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDMC
{/// <summary>
/// Student class that implement gpa cgpa credit hour of student in list
/// </summary>
    class Student
    {
        private string Name;
        private string RegisterationNumber;
        private string Degree;
        private List<CourseResult> Courses=new List<CourseResult>();

        /// <summary>
        /// accessor and mutator for class data member
        /// </summary>
        public string Name1
        {
            get
            {
                return Name;
            }

            set
            {
                if (!invalidName(value)){
                    Name = value;
                }
            }
        }

        public string RegisterationNumber1
        {
            get
            {
                return RegisterationNumber;
            }

            set
            {
                if (!invalidRegisteration(value))
                {
                    RegisterationNumber = value;
                }
            }
        }

        public string Degree1
        {
            get
            {
                return Degree;
            }

            set
            {
               if (!invalidDegree(value))
                {
                    Degree = value;
               }
            }
        }

      

        internal  List<CourseResult> Courses2
        {
            get
            {
                return Courses;
            }

            set
            {
                Courses = value;
            }
        }

        internal List<CourseResult> externalAccessCourse
        {
            get
            {
                return Courses2;
            }

            set
            {
                Courses2 = value;
            }
        }

   /// <summary>
   /// default constructor
   /// </summary>
        public Student()
        {
          
           

        }
        /// <summary>
        /// member function that check validity of name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>boolean</returns>
        public bool invalidName(string name)
        {
            bool isInvalid = false;
            if (name.Any(Char.IsDigit) || name=="" )
            {
                isInvalid = true;
            }
            return isInvalid;
        }
        /// <summary>
        ///member function to validate registeration number
        /// </summary>
        /// <param name="registeration"></param>
        /// <returns>boolean</returns>
        public bool invalidRegisteration(string registeration)
        {
            bool isInvalid = false;
           
            if(registeration.Count() != 11  || !registeration.Split('-')[0].All(Char.IsDigit) || registeration[4] != '-' ||  registeration[7] != '-' ||
                !registeration.Split('-')[1].All(Char.IsLetter) || !registeration.Split('-')[2].All(Char.IsDigit) || 
            !registeration.Split('-')[1].All(Char.IsUpper) )
            {
                isInvalid = true;
            }
            return isInvalid;
        }
        /// <summary>
        /// validate degree program
        /// </summary>
        /// <param name="degree"></param>
        /// <returns>boolean</returns>
        public bool invalidDegree(string degree)
        {

            bool isInvalid = false;
          
            if ( !degree.All(Char.IsUpper) || degree == "" )
            {
                isInvalid = true;
            }
            return isInvalid;
        }
        /// <summary>
        /// member function return unique semester in course
        /// </summary>
        /// <returns></returns>
        public int getSemesters()
        {
            List<string> unique = new List<string>();
            foreach(CourseResult result in Courses)
            {
                if (!unique.Contains(result.Semester1.ToString())){
                    unique.Add(result.Semester1.ToString());
                }
              
                 
            }
            return unique.Count();
            

        }
        
        /// <summary>
        /// function return gpa of semestr passed as parameter
        /// </summary>
        /// <param name="semester"></param>
        /// <returns>GPA</returns>
        public double getSemesterGPA(int semester)
        {
            double totalGradePoint=0.0;
            double creditHour = 0.0;
         
             foreach(CourseResult resultList in Courses)
                 {
                     if (resultList.Semester1 == semester)
                     {
                        totalGradePoint += resultList.getGradePoints()*resultList.CreditHours1;
                    creditHour += resultList.CreditHours1;
                     }
                 }
           
        return totalGradePoint/creditHour;

        }
        /// <summary>
        /// function to get cgpa of a student
        /// </summary>
        /// <returns>CGPA</returns>
        public double getCGPA()
        {
            double totalGradePoint = 0.0;
            double creditHour = 0.0;
            foreach (CourseResult resultList in Courses)
            {
                totalGradePoint += resultList.getGradePoints() * resultList.CreditHours1;
                    creditHour += resultList.CreditHours1;
                
            }
           return totalGradePoint / creditHour;
           }

        /// <summary>
        /// function to get credit hour of semester in course
        /// </summary>
        /// <param name="semester"></param>
        /// <returns>creditHour</returns>
        public int getSemesterCreditHours(int semester)
        {
          
            int creditHour = 0;
         
            foreach (CourseResult resultList in Courses)
            {
                if (resultList.Semester1 == semester)
                {
                    
                    creditHour += resultList.CreditHours1;
                }
            }
           
            return creditHour;

        }

        /// <summary>
        /// function that return total credit hour of student
        /// </summary>
        /// <returns>creditHour</returns>

        public int getTotalCreditHours()
        {
            int creditHour = 0;
             foreach (CourseResult resultList in Courses)
            {
               creditHour += resultList.CreditHours1;
                
            }
            return creditHour;
           }
        /// <summary>
        /// function  that return session of student
        /// </summary>
        /// <returns>session</returns>
        public string getSession()
        {

            return RegisterationNumber.Split('-')[0];
}
        /// <summary>
        /// function that return discipline
        /// </summary>
        /// <returns>discipline</returns>
        public string getDiscipline()
        {
            return RegisterationNumber.Split('-')[1];
        }
        /// <summary>
        /// show all attributes of student class in specific format
        /// </summary>
        /// <returns></returns>
        public string toString()
        {
          string detail = "";
           bool find = false;

            List<int> allSemester = new List<int>();
            foreach (CourseResult resultInfo in Courses)
            {
                allSemester.Add(resultInfo.Semester1);
                
            }

            for (int i = 1; i <= 8; i++)
            {
                if (allSemester.Contains(i))
                {
                    detail += "\nSemester :" + i + "\n\tID" + "\tName" + "\t\t\tCH" + "\tMarks" + "\tGrade\n";
                }
                foreach (CourseResult resultInfo in Courses)
                {
                    if(resultInfo.Semester1==i)
                    detail += string.Format("\t{0}\t{1}\t{2}\t{3}\t{4}",  resultInfo.CourseId1,resultInfo.CourseTitle1,
                        resultInfo.CreditHours1, resultInfo.Marks1, resultInfo.getGrade());
                    find = true;
                }

               
                if (find)
                {
                    if (!double.IsNaN(getSemesterGPA(i)))
                    {
                        detail += "\t\t\t\t\t\t\tSGPA : ";

                        detail += getSemesterGPA(i).ToString();
                    }
                }
            //    find = false;
               
              
            }
            detail += "\n\t\t\t\t\t\tCGPA : " + getCGPA().ToString().PadLeft(5);
            return string.Format("Name:{0}\tDegree:{1} {2} \n Registeration Number : {3} \n Session:{4} \n {5}", 
                Name, Degree,getDiscipline(),RegisterationNumber,getSession(),detail);
           
        }

    }
}
