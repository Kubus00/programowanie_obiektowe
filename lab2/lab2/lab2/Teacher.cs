using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Teacher
    {
        class Teacher
        {
            private string name;
            private int age;

            public Teacher(string name, int age)
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
