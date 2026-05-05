using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Person
    {
        //תכונות המחלקה - לכל מופע יהיו את כל התכונות שהגדרנו בקלאס
        private string name;
        private int age; //upto 125
        private char gender; //m || f
        private bool hasGlasses; //T || F

        //העמסת בנאים - ברגע שיוצרים בנאי במחלקה - הבנאי הדיפולטיבי נדרס
        public Person() { }
        public Person(string name, int age, char gender, bool hasGlasses) //בנאי שיוצר את האובייקט/מימוש/מופע
        {
            SetName(name);
            SetAge(age);
            SetHasGlasses(hasGlasses);
            SetGender(gender);
        }

        //פונקציות גישה + ולידציות לתכונות
        public void SetName(string name) //פונקציית סט
        {
            while(name.Contains(",") || name.Contains(".")) //Validation
            {
                Console.WriteLine("Invalid value - Enter a valid name");
                name = Console.ReadLine();
            }

            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }

        public void SetAge(int age)
        {
            while(age < 0 || age > 120)
            {
                Console.WriteLine("Invalid age");
                age = int.Parse(Console.ReadLine());
            }
            this.age = age;
        }
        public int GetAge() { return this.age; }
        public void SetGender(char gender)
        {
            while(!(gender == 'm' || gender == 'f' || gender == 'M' || gender == 'F'))
            {
                Console.WriteLine("Invalid gender");
                gender = char.Parse(Console.ReadLine());
            }
            this.gender = gender;
        }
        public char GetGender() { return this.gender; }
        public void SetHasGlasses(bool g) {
            this.hasGlasses = g;
        }
        public bool GetHasGlasses() { return this.hasGlasses; }

    }
}
