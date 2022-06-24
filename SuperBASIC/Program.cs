﻿using System;
using System.IO;

namespace SuperBASIC
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Library lib = new Library();
#if MEMORY
				lib.AddFunction(new Functions.MemoryLoad(), 1, "MEMLOAD");
				lib.AddFunction(new Functions.MemoryStore(), 2, "MEMSTORE");
#endif
				lib.AddFunction(new Functions.Print(), 1, "PRINT");
				lib.AddFunction(new Functions.Multiply(), 2, "MULTIPLY");
				lib.AddFunction(new Functions.Add(), 2, "ADD");
				lib.AddFunction(new Functions.Compare(), 2, "COMPARE");
				lib.AddFunction(new Functions.JumpZero(), 2, "JZ");
				lib.AddFunction(new Functions.Goto(), 1, "GOTO");
				lib.AddFunction(new Functions.Pi(), 0, "PI");
				lib.AddFunction(new Functions.Euler(), 0, "EULER");

				lib.AddFunction(new Functions.Arcsin(), 1, "ARCSIN");
				lib.AddFunction(new Functions.Rem(), 2, "REM");
				lib.AddFunction(new Functions.Accumulate(), 2, "ACCUMULATE");
				lib.AddFunction(new Functions.Cylinder_vol(), 2, "CYLINDER_VOL");
				lib.AddFunction(new Functions.LinearEquation(), 3, "LINEAR");
				lib.AddFunction(new Functions.Sphere_vol(), 2, "SPHERE_VOL");
				Runtime r = new Runtime(lib);
				if (args.Length <= 1)
				{
					r.OpenFile(Directory.GetCurrentDirectory() + "\\Test.basic");
				} 
				else
				{
					r.OpenFile(args[1]);
				}
				r.Run();
			} catch (Parser.ParseException e)
			{
				Console.WriteLine($"Parsing failed:\n{e}");
			}
		}
	}
}
