﻿using System;

namespace ComputeQuotientRemainder
{
	class Program
	{
		static void Main(string[]args)
		{
			int dividend = 70, divisor = 8;

			int quotient = dividend / divisor;
			int remainder = dividend % divisor;

			Console.WriteLine("Dividend: {0} Divisor: {1}", dividend, divisor);
			Console.WriteLine("Quotient = " + quotient);
			Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
	}
}











