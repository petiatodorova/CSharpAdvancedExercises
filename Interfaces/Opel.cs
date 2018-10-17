using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Opel : Car
    {
        public Opel(int year, string model)
            : base(year, model)
        {
           
        }

        public override string SayBrum() => "Brum from Opel";
    }
}
