﻿using System;
using System.Collections.Generic;
using System.Text;


namespace SuperBASIC.Functions
{
	class ConstantPolynomialException : Exception { }
	public class Add : IFunction
	{
		float IFunction.Apply(List<BasicNumber> arguments)
		{

			return arguments[0] + arguments[1];
			
		}
	}
}
