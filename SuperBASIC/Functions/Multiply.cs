﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
	public class Multiply : IFunction
	{
		float IFunction.Apply(List<BasicNumber> arguments)
		{
			return arguments[0] * arguments[1];
		}
	}
}
