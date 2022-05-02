using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man("Nick",18);
            Console.WriteLine(" Man:");
            man.Display();
            Console.WriteLine();

            Student student = new Student(man,4,"KN");
            Console.WriteLine(" Student:");
            student.Display();
            Console.WriteLine();

            Graduatecs graduatecs = new Graduatecs(student, "Blockchain");
            Console.WriteLine(" Graduatecs:");
            graduatecs.Display();

            Console.ReadKey();
        }
    }
}
