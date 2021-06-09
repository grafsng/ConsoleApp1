using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            student bob = new student("Abay",3);
            bob.Itog();

            student tom = new student("Leha") { score = 5 };
            tom.Itog();


            user j = new user("Vlad",4);
           
            j.Itog();

            
        }
    }

    struct user
    {
        public string name;
        public int score;
        public user(string name,int score)
        {
            this.name = name;
            this.score = score;
        }
        public void Itog()
        {
            Console.WriteLine($"Loh {name}, u tebya {score}");
        }


        
    }
}
