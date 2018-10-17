using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Mercedes : Car
    {
        public Mercedes(int year, string model) 
            : base(year, model)
        {

        }

        public override string SayBrum() => "Brum from Mercedes";
    }
}
