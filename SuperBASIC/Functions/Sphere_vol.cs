using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    public class Sphere_vol : IFunction
    {
        float IFunction.Apply(List<BasicNumber> arguments)
        {
            return (float)(Math.PI * Math.Pow(arguments[0].GetValue(), 3) / 3);
        }
    }
}
