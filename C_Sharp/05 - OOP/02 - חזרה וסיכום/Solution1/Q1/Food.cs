using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Food
    {
        // תכונות
        string name; //private גם אם אני לא כותב זה תמיד יהיה 
        private char type;
        private double weight;
        private int daysToExpired;

        #region בנאים
        public Food(string name, char type, double weight)
        {
            SetName(name);
            SetFoodType(type);
            SetWeight(weight);
        }

        public Food(string name, char type, double weight, int daysToExpired) : this(name, type, weight)
        {
            SetDaysToExpired(daysToExpired);
        }
        #endregion

        #region GET פעולות 
        public string GetName() { return name; }
        public char GetFoodType() { return type; }
        public double GetWeight() { return weight; }
        public int GetDaysToExpired() { return daysToExpired; }
        #endregion

        #region SET פעולות 
        public void SetWeight(double weight)
        {
            if (weight > 0)
                this.weight = weight;
            else
            {
                this.weight = 0;
                Console.WriteLine("Invalid weight! weight set to 0.");
            }
        }

        public void SetFoodType(char type)
        {
            if (type == 'v' || type == 'f' || type == 'p' || type == 'm' || type == 'd')
                this.type = type;
            else
            {
                Console.WriteLine("Invalid type!");
            }
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetDaysToExpired(int daysToExpired)
        {
            if (daysToExpired > 0)
                this.daysToExpired = daysToExpired;
            else
            {
                this.daysToExpired = 0;
                Console.WriteLine("Invalid days to expired! days to rxpired set to 0.");
            }
        }
        #endregion

        //שיטות נוספות
        public void PrintExperationDate()
        {
            if(daysToExpired == 0)
            {
                Console.WriteLine("No Experation Date");
                return; // מסיים את הפונקציה
            }

            //DateTime שליפת התאריך של היום באמצעות המחלקה 
            DateTime today = DateTime.Today;
            
            //הוספה של ימי התפוגה
            today = today.AddDays(daysToExpired);

            //הדפסה של תאריך התפוגה
            Console.WriteLine(today.ToString("d/M/yyyy"));
        }
    }
}
