using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Student
    {
        public class Student
        {
            public class Student
            {
                private string group;
                private List tasks;
                public string group;
                public Student(string name, int age)
                {
                    this.name = name;
                    this.age = age;
                }

                public bool Equals(Teacher other)
                {
                    if (other == null) return false;
                    if (other == this) return true;

                    return Object.Equals(this.name, other.name) && Object.Equals(this.age, other.age);
                }
            }
        }
    }
}
