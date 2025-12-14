using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2.Exercise_1
{
    public class Student
    {
        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name { get { return name; } }
        public int Age { get { return age; } }

        public void Introduce()
        {
            Console.WriteLine($"Hello , my name is {name} and I am {age} years old");
        }
    }
}
