using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_8
{
    public class Graduatecs:Student
    {
        private Student _student;
        private string _thesis_topic;

        public Student get_student() { return this._student; }
        public string get_thesis_topic() { return this._thesis_topic; }
        public void set_student(Student student) { this._student = student; }
        public void set_thesis_topic(string thesis_topic) { this._thesis_topic = thesis_topic;}
        public Graduatecs() { this._student = new Student(); this._thesis_topic = " "; }
        public Graduatecs(Student student, string thesis_topic) { this._student = student; this._thesis_topic = thesis_topic; }
        public Graduatecs(Graduatecs g) { this._student = g._student;this._thesis_topic=g._thesis_topic; }

        public void Read()
        {
            this._student.Read();
            Console.WriteLine(" Thesis_topic: ");
            this._thesis_topic = Console.ReadLine();
        }
        public void Display()
        {
            this._student.Display();
            Console.Write($" Thesis_topic: {this._thesis_topic}\n");

        }

    }
}
