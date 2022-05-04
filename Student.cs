using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_8
{
    public class Student:Man
    {
       
        private int _kurs;
        private string _specialty;
       
        public int get_kurs() { return this._kurs; }
        public string get_specialty() { return this._specialty; }
        public void set_specialty(string specialty) { this._specialty = specialty; }
        public void set_kurs(int kurs) { this._kurs = kurs; }

        public Student() { this.set_name(" ");this.set_age(0);  this._kurs = 0;this._specialty = ""; }
        public Student(string name, int age, int kurs,string specialty) { this.set_name(name); this.set_age(age); this._kurs = kurs; this._specialty = specialty; }
        public Student(Man person, int kurs, string specialty) { this.set_name(person.get_name()); this.set_age(person.get_age()); this._kurs = kurs; this._specialty = specialty; }
        public Student(Student s) {this.set_name(s.get_name()); this.set_age(s.get_age()); this._kurs = s._kurs;this._specialty = s._specialty;  }

        public void Read()
        {
            string name;
            int age;
            Console.WriteLine(" Name: ");
            name = Console.ReadLine();
            this.set_name(name);
            Console.WriteLine(" Age: ");
            age = Convert.ToInt32(Console.ReadLine());
            this.set_age(age);
            Console.WriteLine(" Сourse: ");
            this._kurs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Specialty: ");
            this._specialty = Console.ReadLine();
        }
        public void Display()
        {
          
            
            Console.Write($" Name: {this.get_name()}\n Age: {this.get_age()}\n Сourse: {this._kurs}\n Specialty: {this._specialty}\n");
           
        }
       
    }
}
