using System;
using System.Collections.Generic;

namespace oop1
{
    class Person
    {
        private string name;
        private int age;
        private decimal salary;
        private string[] address;
        public void CalculateAge() { }
        public virtual void CalculateSalary() { }
        public void getAddress() { }
    }
    abstract class Instructor : Person
    {
        private string department;
        private bool head;
        private DateTime joinDate;
        public override void CalculateSalary()
        {
            //calculate bonus based on joindate
        }
    }
    abstract class Student : Person
    {
        private List<string> courseTaken;
        private Dictionary<string,string> grades;
        public decimal GPA(Dictionary<string,string> grades)
        {
            decimal gpa = 0;
            //calculation
            return gpa;
        } 
    }
    class Course
    {
        private List<string> enrolledStudent;

    }
    class Department
    {
        private string head;
        private int budget;
        private List<string> courses;
    }
    class Program1
    {
        static void Main(string[] args)
        {
            
        }
    }
}
