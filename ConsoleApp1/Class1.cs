using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class student
    {
        public string name;
        public int score;
        public void Itog()
        {
            Console.WriteLine($"Loh {name}, u tebya {score}");
        }


        public student(string name)
        {
            this.name = name;
        }

        public student(string n, int s) : this(n)
        {

            score = s;
        }
    }
}
