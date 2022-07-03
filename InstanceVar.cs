using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// if variable is explicitly declared by using the static modifer or else if a variable is declared ubnder 
// under any static block then those variable are static variable as rest of the other are non-static.

   
     class InstanceVar
     {
          int rollNo;
         string firstname;
         string lastname;
         int Marks;
       public static void Main(string[] args)
       {
            InstanceVar Nitish = new InstanceVar();
            Nitish.firstname = "Nitish";
            Nitish.lastname = "Mehta";
            Nitish.Marks = 500;
            Nitish.rollNo = 161;
            InstanceVar Teacher = new InstanceVar();
            Teacher.Marks = 1000;
            Teacher.firstname = "Murli";
            Teacher.lastname = "Krishan";
            Console.WriteLine("Student Fullname: "+ Nitish.firstname+"  " + Nitish.lastname  + 
                "Student marks:  " + Nitish.Marks);
            Console.WriteLine("teacher Fullname: " + Teacher.firstname+"  " + Teacher.lastname +
                "Student marks:  " + Teacher.Marks);
       }
    }

