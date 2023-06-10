﻿using System;
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
        public int year;

        // Constructor
        public Student(string aName, string aCourse, int aAge, int aYear)
        {
            name = aName;
            course = aCourse;
            age = aAge;
            year = aYear;
        }
    }

}