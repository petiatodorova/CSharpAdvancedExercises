using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public abstract class Car
    {
        public Car(int year, string model)
        {
            this.Year = year;
            this.Model = model;
        }

        public int Year { get; private set; }

        public string Model { get; private set; }

        public abstract string SayBrum();
    }
}
