using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Student
    {
        string id;
        float cgpa;
        string name;
        string department;
            public void insert (string Name, string Id, string Department, float Cgpa)
            {
            name = Name;
            department = Department;
            cgpa = Cgpa;
            id = Id ;
            }
    public void Showinfo()
    {
        Console.WriteLine("Name : " + name);
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Depatment : " + department);
            Console.WriteLine("Cgpa : " + cgpa);

        }

        class Course
        {
            string courseName;
            string courseCode;
            int courseCredit;
             public void insert (
                 string CourseCode, int CourseCredit, string CourseName)
            {
                courseName = CourseName;
                courseCode = CourseCode;
                courseCredit = CourseCredit;
            }
            public void Showinfo()
            {
                Console.WriteLine("CourseName : " + courseName);
                Console.WriteLine("CourseCredit : " + courseCredit);
                Console.WriteLine("CourseCode : " + courseCode);
            }
        }

        class Account
        {
            string accountName;
            string accountId;
            float balance;

            public void insert( string AccountName, string AccountId, float Balance)
            {
                accountName = AccountName;
                accountId = AccountId;
                balance = Balance;
            }
            public void Deposit(float Balance, float ammount)
            {
                balance = balance + ammount;
            }
            public void Withdraw(float Balance, float ammount)
            {
                balance = balance - ammount;
            }
        }

        class Triangle
        {
            int a;
            int b;
            int c;

            public int getA() { return a; }
            public void setA(int A) { a = A; }

            public int getB() { return b; }
            public void setB(int B) { b = B; }

            public int getC() { return c; }
            public void setC(int C) { c = C; }

            public void Showinfo()
            {
                Console.WriteLine("A:" + a);
                Console.WriteLine("B:" + b);
                Console.WriteLine("C:" + c);

            }

            public void TestTriangle()
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("The triangle is equilateral");
                }

                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("The triangle is isosceles");
                }

                else
                {
                    Console.WriteLine("The triangle is scalene");
                }
                
            }
        }




    }
}
