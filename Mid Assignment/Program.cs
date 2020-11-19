using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to University Management System");
            Console.WriteLine("Created By Rafik Rokon");
            Console.WriteLine("Developer At Kuratoli Software Solutions");            
            Course c = new Course("Java",001,3,5.0,1);
            Course c1 = new Course("C#", 003, 3, 5.0, 1);
            Section s = new Section("A","C#", 001,3, 5.0);
            Section s1 = new Section("B", "C#", 001, 3, 3.0);
            Section s2 = new Section("C", "C#", 001, 3, 3.0);
            Section s3 = new Section("D", "C#", 001, 3, 3.0);
            Section s4 = new Section("M", "C#", 001, 3, 3.0);
            Section s5= new Section("E", "OOP1", 002, 3, 3.0);
            Section s6 = new Section("F", "OOP1", 002, 3, 3.0);
            Section s7 = new Section("G", "OOP1", 002, 3, 3.0);
            Section s8 = new Section("H", "OOP1", 002, 3, 3.0);
            Section s9 = new Section("I", "OOP1", 002, 3, 3.0);
            s.SearchSection(001);
            Console.WriteLine("Seacrhing For Section");
            c.SearchSection(001);
            Console.WriteLine("``");
            c.ShowInfo();
            Departments d = new Departments("CSE");
            Departments d1 = new Departments("BBA");
            Departments d2 = new Departments("EEE");
            Departments d3 = new Departments("ECO");
            d.AddCourse(c1,c);
            d.ShowAllCourses();
            Console.WriteLine("Adding Courses In Department");
            d.AddCourse(s, s1, s2, s3,s4,s5,s6,s7,s8,s9);
            d.ShowAllCourses();
            Console.WriteLine("Course Faculty");
            Faculty f = new Faculty("Sajjadul Bari", "20-001");
            Faculty f1 = new Faculty("Theotoinus Gomez", "20-002");
            Faculty f2= new Faculty("Victor Rozario", "20-003");
            Faculty f3 = new Faculty("Hasib Hasan", "20-004");
            Faculty f4 = new Faculty("Rakib Hasan", "20-005");
            Teaching_Hour t = new Teaching_Hour("C programming", 3,d);
            Teaching_Hour t1 = new Teaching_Hour("C++ programming", 3, d);
            Teaching_Hour t2 = new Teaching_Hour("Java", 3, d);
            Teaching_Hour t3 = new Teaching_Hour("C#", 3, d);
            Teaching_Hour t4 = new Teaching_Hour("TOC", 3, d);
            Teaching_Hour t5 = new Teaching_Hour("OOAD", 3, d);
            Teaching_Hour t6 = new Teaching_Hour("Economics", 3, d2);
            Teaching_Hour t7 = new Teaching_Hour("SE", 3, d);
            Teaching_Hour t8 = new Teaching_Hour("Math1", 3, d1);
            Teaching_Hour t9 = new Teaching_Hour("Math2", 3, d1);
            Teaching_Hour t10 = new Teaching_Hour("Math3", 3, d1);
            Teaching_Hour t11 = new Teaching_Hour("Math4", 3, d1);
            Teaching_Hour t12 = new Teaching_Hour("Math5", 3, d2);
            Teaching_Hour t13 = new Teaching_Hour("Business Communication", 3, d2);
            Teaching_Hour t14 = new Teaching_Hour("Bangladesh Studies", 3, d2);
            Teaching_Hour t15 = new Teaching_Hour("Accounting", 3, d3);
            Teaching_Hour t16 = new Teaching_Hour("AC", 3, d3);
            Teaching_Hour t17 = new Teaching_Hour("Computer Networks", 3, d3);
            Teaching_Hour t18 = new Teaching_Hour("Database", 3, d);
            Teaching_Hour t19 = new Teaching_Hour("Data Structure", 3, d);
            Teaching_Hour t20 = new Teaching_Hour("DC", 3, d);
            Console.WriteLine("Faculty Information");
            f.ShowInfo();
            f.AddCredit(t, t1, t2, t3, t4, t5,t18);
            f1.ShowAllCredits();


        }
    }
}
