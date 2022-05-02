using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_8
{
    public class Man
    {
        private string _name;
        private int _age;

        public string get_name() { return _name; }
        public int get_age() { return _age; }

        public void set_name(string name) { _name = name; }
        public void set_age(int age) { _age = age; }
        public Man() { this._name = " ";this._age = 0;}
        public Man(string name, int age) { this._name = name; this._age = age; }
        public Man(Man m) { this._name = m._name; this._age = m._age; }

        public void Read()
        {
            Console.WriteLine(" Name: ");
            this._name = Console.ReadLine();
            Console.WriteLine(" Age: ");
            this._age = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            Console.Write($" Name: {this._name}\n Age: {this._age}\n");
        }
        

    }
}
