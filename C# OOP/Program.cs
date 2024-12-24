// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using C__OOP.Models;
using System.Diagnostics;
using System.Xml.Linq;

Students studentclass = new Students();
string name, major;
double Gpa;
Console.WriteLine("enter your name: ");
name = Console.ReadLine();
Console.WriteLine("enter your major: ");
major = Console.ReadLine();
Console.WriteLine("enter your GPA: ");
Gpa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(studentclass.studentSummary(name, major, Gpa));





