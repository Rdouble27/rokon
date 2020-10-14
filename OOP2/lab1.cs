using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagonstics.CodeAnalysis;
using System.Text;
using System.Threading.Tasks;
System.Runtime.InteropServices;

namespace Lab_1 

  {
      class program {
          static void Main(string[]args)
      
      
      {
          Console.Write("Hello");
          Console.WriteLine("Rokon");
          
          
          int x = 2;
          int y = 4;
          int sum = x+y;
          
          Console.WriteLine("Sum of two numbers are:" +sum);
          
          int division = y/x;
          
          Console.WriteLine("division of two numbers:" + division);
          
          int statement1 = -5+8*6;
          int statement2 = (55+9)%9;
          int statement3 = 20+-3*5/8;
          int statement4 = 5+15/3*2 - 8%3;
          
          
          Console.WriteLine("Statement1:" + statement1);
          Console.WriteLine("Statement2:" + statement2);
          Console.WriteLine("Statement3:" + statement3);
          Console.WriteLine("Statement4:" + statement4);
          
          int a = 10;
          int b = 5;
          
          int add = a+b;
          int multiply = a*b;
          int div = a/b;
          int reminder = a%b;
          int sub = a-b;
          
          Console.WriteLine("Addition of two numbers:" + add);
          Console.WriteLine("Multiplication of two numbers:" + multiply);
          Console.WriteLine("Division of two numbers:" + div);
          Console.WriteLine("Reminder of two numbers:" + reminder);
          Console.WriteLine("Substraction of two numbers:" + sub);
          
          double expression = (25.5*3.5-3.5 * 3.5)/ (40.5 - 4.5);
          Console.WriteLine("Output of EXpression:" + expression);
          
          double width = 5.5;
          double height = 8.5;
          
          double area = width*height;
          double perimeter = 2*(width*height);
          
          Console.WriteLine("Area is:" + area);
          Console.WriteLine("Perimeter is:" + perimeter);
      }
    }   
  }