using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Destination
    {
        // private fields
        private string name;
        private double price;
        private int numOfTickets;

        public Destination(string name, double price, int numOfTickets)
        {
            SetName(name);
            SetPrice(price);
            SetNumOfTickets(numOfTickets);
        }

        // Set and Get methods (no properties)
        public void SetName(string value)
        {
            name = value;
        }

        public string GetName()
        {
            return name;
        }

        public void SetPrice(double value)
        {
            price = value;
        }

        public double GetPrice()
        {
            return price;
        }

        public void SetNumOfTickets(int value)
        {
            numOfTickets = value;
        }

        public int GetNumOfTickets()
        {
            return numOfTickets;
        }

        public override string ToString()
        {
            return $"Name: {name}, Price: {price}, NumOfTickets: {numOfTickets}";
        }
    }
}
