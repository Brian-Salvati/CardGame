/*
Brian Salvati
HW2
*/

using System;
using System.Collections.Generic;

namespace HW2
{
	public class Suit
	{
		public static List<Suit> VALUES = new List<Suit>();
		public static Suit CLUBS, DIAMONDS, HEARTS, SPADES;

		private string name;
		private string symbol;

		static Suit()
		{
			CLUBS = new Suit ("CLUBS", "C");
			DIAMONDS = new Suit ("DIAMONDS", "D");
			HEARTS = new Suit ("HEARTS", "H");
			SPADES = new Suit ("SPADES", "S");
		}

		public Suit (string n, string s)
		{
			name = n;
			symbol = s;
			VALUES.Add (this);
		}

		public int CompareTo(Suit OtherSuitObject)
		{
			if (VALUES.IndexOf (this) == VALUES.IndexOf (OtherSuitObject))
				return 0;
			else if (VALUES.IndexOf (this) < VALUES.IndexOf (OtherSuitObject))
				return -1;
			else
				return 1;
		}

		string GetSymbol()
		{
			return symbol;
		}

		string GetName()
		{
			return name;
		}

		public override string ToString()
		{
			return name;
		}
	}
}

