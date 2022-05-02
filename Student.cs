using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_8
{
    public class Student:Man
    {
    
        
        private Man _person;
        private int _kurs;
        private string _specialty;
        
        public Man get_man() { return this._person; }
        public int get_kurs() { return this._kurs; }
        public string get_specialty() { return this._specialty; }
        public void set_specialty(string specialty) { this._specialty = specialty; }
        public void set_kurs(int kurs) { this._kurs = kurs; }
        public void set_man(Man person) { this._person = person;}

        public Student() { this._person = new Man(); this._kurs = 0;this._specialty = ""; }
        public Student(Man person, int kurs,string specialty) { this._person = person; this._kurs = kurs; this._specialty = specialty; }
        public Student(Student s) { this._person = s._person;this._kurs = s._kurs;this._specialty = s._specialty;  }

        public void Read()
        {
            this._person.Read();
            Console.WriteLine(" Сourse: ");
            this._kurs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Specialty: ");
            this._specialty = Console.ReadLine();
        }
        public void Display()
        {
            this._person.Display();
            Console.Write($" Сourse: {this._kurs}\n Specialty: {this._specialty}\n");
           
        }
       
    }
}
