using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        public string eyeColor;
        public string hairColor;
        public int age;

        public Person(string eyeColor, string hairColor, int age)
        {
            
        }
        public Person()
        {

        }
        public Person(Person p) {
            this.eyeColor = p.eyeColor;
            this.hairColor = p.hairColor;
            this.age = p.age;
        }
        }
    }
