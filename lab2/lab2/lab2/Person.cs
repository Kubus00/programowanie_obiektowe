using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Person
    {
        private string name;
        private int age;
        public string name;
        public int age;


        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public bool Equals(Person other)
        {
            if (other == null) return false;
            if (other == this) return true; 

            return Object.Equals(this.name, other.name) && Object.Equals(this.age, other.age);
        }
    }
}
