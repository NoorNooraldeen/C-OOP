using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP.Models


{
    public class Students
    {

        public string Name;
        public string Major;
        public double GPA;

        public string studentSummary(string name, string major, double GPA)
        {

            return "student name is:  " + name + "\nstudent major is: " + major + "\nstudent gpa is: " + GPA;
        }
    }
}

