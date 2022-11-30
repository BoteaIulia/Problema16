using System;

public static class Globals
{
	internal static void Main()
	{
		Console.Write("Ordonati crescator cele 5 numere:");
		Console.Write("\n");
		int a;
		int b;
		int c;
		int d;
		int e;
		int aux;
		Console.Write("a = ");
		a = Convert.ToInt32(Console.ReadLine());
		Console.Write("b = ");
		b = Convert.ToInt32(Console.ReadLine());
		Console.Write("c = ");
		c = Convert.ToInt32(Console.ReadLine());
		Console.Write("d = ");
		d = Convert.ToInt32(Console.ReadLine());
		Console.Write("e = ");
		e = Convert.ToInt32(Console.ReadLine());

		if (a > b)
		{
			aux = a;
			a = b;
			b = aux;
		}
		if (a > c)
		{
			aux = a;
			a = c;
			c = aux;
		}
		if (a > d)
		{
			aux = a;
			a = d;
			d = aux;
		}
		if (a > e)
		{
			aux = a;
			a = e;
			e = aux;
		}
		if (b > c)
		{
			aux = b;
			b = c;
			c = aux;
		}
		if (b > d)
		{
			aux = b;
			b = d;
			d = aux;
		}
		if (b > e)
		{
			aux = b;
			b = e;
			e = aux;
		}
		if (c > d)
		{
			aux = c;
			c = d;
			d = aux;
		}
		if (c > e)
		{
			aux = c;
			c = e;
			e = aux;
		}
		Console.Write("Numerele ordonate sunt :");
		Console.Write("\n");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(b);
		Console.Write(" ");
		Console.Write(c);
		Console.Write(" ");
		Console.Write(d);
		Console.Write(" ");
		Console.Write(e);
		Console.Write(" ");
	}
}

//Helper class added by C++ to C# Converter:

//----------------------------------------------------------------------------------------
//	Copyright © 2006 - 2022 Tangible Software Solutions, Inc.
//	This class can be used by anyone provided that the copyright notice remains intact.
//
//	This class provides the ability to convert basic C++ 'cin' and C 'scanf' behavior.
//----------------------------------------------------------------------------------------
internal static class ConsoleInput
{
	private static bool goodLastRead = false;
	public static bool LastReadWasGood
	{
		get
		{
			return goodLastRead;
		}
	}

	public static string ReadToWhiteSpace(bool skipLeadingWhiteSpace)
	{
		string input = "";

		char nextChar;
		while (char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
		{
			//accumulate leading white space if skipLeadingWhiteSpace is false:
			if (!skipLeadingWhiteSpace)
				input += nextChar;
		}
		//the first non white space character:
		input += nextChar;

		//accumulate characters until white space is reached:
		while (!char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
		{
			input += nextChar;
		}

		goodLastRead = input.Length > 0;
		return input;
	}

	public static string ScanfRead(string unwantedSequence = null, int maxFieldLength = -1)
	{
		string input = "";

		char nextChar;
		if (unwantedSequence != null)
		{
			nextChar = '\0';
			for (int charIndex = 0; charIndex < unwantedSequence.Length; charIndex++)
			{
				if (char.IsWhiteSpace(unwantedSequence[charIndex]))
				{
					//ignore all subsequent white space:
					while (char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
					{
					}
				}
				else
				{
					//ensure each character matches the expected character in the sequence:
					nextChar = (char)System.Console.Read();
					if (nextChar != unwantedSequence[charIndex])
						return null;
				}
			}

			input = nextChar.ToString();
			if (maxFieldLength == 1)
				return input;
		}

		while (!char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
		{
			input += nextChar;
			if (maxFieldLength == input.Length)
				return input;
		}

		return input;
	}
}
