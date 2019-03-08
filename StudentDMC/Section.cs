using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDMC
{
    /// <summary>
    /// section class to implement the student list (containing result of student)
    /// </summary>
    class Section
    {
        private  List<Student> studentList = new List<Student>();
        private static Section Instance = null;

        internal  List<Student> StudentList
        {
            get
            {
                return studentList;
            }

            set
            {
                studentList = value;
            }
        }

        internal static Section Instance1
        {
            get
            {
                return Instance;
            }

            set
            {
                Instance = value;
            }
        }
        /// <summary>
        /// function that inputs Student obj and insert in studentList
        /// </summary>
        /// <param name="obj"></param>
        public void addStudent(Student obj)
        {
            studentList.Add(obj);
        }
        /// <summary>
        /// function to getlist of all student 
        /// </summary>
        /// <returns>studentList</returns>
        public List<Student> ListofStudents()
        {
            return studentList;
        }
        /// <summary>
        /// function to get list of suspended student
        /// </summary>
        /// <returns>suspendedStudent</returns>
        public List<Student> ListofSuspendedStudents()
        {
            List<Student> suspendedStudent = new List<Student>();
            foreach(Student St in studentList)
            {
                if (St.getCGPA() < 2.0)
                {
                    suspendedStudent.Add(St);
                }
            }
            return suspendedStudent;
        }
        /// <summary>
        /// null constructor
        /// </summary>
        private Section()
        {

        }

        /// <summary>
        /// function that implement the functionality of singleton 
        /// </summary>
        /// <returns>Section</returns>
        public static Section getInstance()
        {
            if (Instance == null)
            {
                Instance = new Section();
            }
            return Instance;
        }
    }
}
