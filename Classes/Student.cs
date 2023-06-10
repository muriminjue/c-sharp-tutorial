using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Student
    {
        public string name;
        public string course;
        public int age;
        private int year;
        public static int studentCount;
        // Constructor
        public Student(string aName, string aCourse, int aAge, int aYear)
        {
            name = aName;
            course = aCourse;
            age = aAge;
            Year = aYear;
            studentCount++;
        }

        public int Year
        {
            get { return year; }
            set { 
                if (value > 0 && value < 7)
                {
                    year = value;
                }
                else
                {
                    year = 0;
                } 
            }
        }
        public bool Minor()
        {
            if(age >=18) { return true; }
            return false;
        }

        public int StudentCount
        {
            get { return studentCount; }
        }
    }

}