using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_8
{
    public class Graduatecs:Student
    {
        
        private string _thesis_topic;

        
        public string get_thesis_topic() { return this._thesis_topic; }
        public void set_thesis_topic(string thesis_topic) { this._thesis_topic = thesis_topic;}
        public Graduatecs() { this.set_name("");this.set_age(0);this.set_kurs(1);this.set_specialty(" "); this._thesis_topic = " "; }
        public Graduatecs(Student student, string thesis_topic) { this.set_name(student.get_name()); this.set_age(student.get_age()); this.set_kurs(student.get_kurs()); this.set_specialty(student.get_specialty()); this._thesis_topic = thesis_topic; }
        public Graduatecs(Graduatecs g) { 
            this.set_name(g.get_name()); 
            this.set_age(g.get_age());
            this.set_kurs(g.get_kurs());
            this.set_specialty(g.get_specialty()); 
            this._thesis_topic=g._thesis_topic; }

        public void Read()
        {
            string name;
            int age;
            string specialty;
            int kurs;

            Console.WriteLine(" Name: ");
            name = Console.ReadLine();
            this.set_name(name);
            Console.WriteLine(" Age: ");
            age = Convert.ToInt32(Console.ReadLine());
            this.set_age(age);
            Console.WriteLine(" Specialty: ");
            specialty = Console.ReadLine();
            this.set_specialty(specialty);
            Console.WriteLine(" Age: ");
            kurs = Convert.ToInt32(Console.ReadLine());
            this.set_kurs(kurs);
            Console.WriteLine(" Thesis_topic: ");
            this._thesis_topic = Console.ReadLine();
        }
        public void Display()
        {
            
            Console.Write($" Name: {this.get_name()}\n Age: {this.get_age()}\n Сourse: {this.get_kurs()}\n Specialty: {this.get_specialty()}\n Thesis_topic: {this._thesis_topic}\n");

        }

    }
}
