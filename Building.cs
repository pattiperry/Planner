using System;
using System.Collections.Generic;

namespace Planner
{
    //creating a custom class of building 
    public class Building
    {
        //public properties
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        //private fields
        private string _designer = "Patti Perry";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        //building a constructor method that accepts a single argument of address as a parameter 
        public Building(string address)
        {
            _address = address;

        }

        // public void GetAddress()
        // {
        //     Console.WriteLine(this._address);
        // }

        //public method that should set the _dateConsturcted field's value to DateTime.now
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        //public method that should set the _ownder field to name of the person purchasing a building
        public void Purchase(string owner)
        {
            _owner = owner;
        }

        //creating a method that will print the address, designed by: , constructed by: , owned by: , and the cubic meters of space (all the properties of the building class) in the terminal when called in the main method on program.cs
        public void PrintBuilding()
        {
            Console.WriteLine($"\n {this._address}\n-----------------------\n Designed by {this._designer} \n Constructed by {this._dateConstructed}\n Owned by {this._owner} \n {this.Volume} cubic meters of space");
        }

    }
}
