using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface ICar
    {

        int Year { get; }

        string Model { get; }

        string SayBrum();

    }
}
