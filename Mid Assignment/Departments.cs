using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class Departments
    {
        public string DepartmentName{ get; set; }       
        public int totalCourse { get; set; }
        public Section Section { get; set; }        
        public int CreditCount { get; set; }
        public Departments()
        {
            listOfCourses = new Course[100];
            teachingHours = new Teaching_Hour[1000];
        }
        public Departments(string name)
        {
            DepartmentName = name;
            listOfCourses = new Course[100];
            teachingHours = new Teaching_Hour[1000];


        }
        public void ShowInfo()
        {
            Console.WriteLine("Name Of The Department: " + DepartmentName);
            Console.WriteLine("Total Number Of Courses: " + totalCourse);
        }
        
        }
        public void AddNewCourseNumber(Course course, int number)
        {
            course.AddCourseNumber(number);
        }
        
        public void ShowAllCourses()
        {
            for (int i = 0; i < totalCourse; i++)
            {
                listOfCourses[i].ShowInfo();
            }
        }
       
        
        

    }
}
