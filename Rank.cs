/*
Brian Salvati
HW2
*/

using System;
using System.Collections.Generic;

namespace HW2
{
	public class Rank
	{
		public static List<Rank> VALUES = new List<Rank>();
		public static Rank TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING, ACE;

		private string name;
		private string symbol;

		static Rank()
		{
			TWO = new Rank ("TWO", "2");
			THREE = new Rank ("THREE", "3");
			FOUR = new Rank ("FOUR", "4");
			FIVE = new Rank ("FIVE", "5");
			SIX = new Rank ("SIX", "6");
			SEVEN = new Rank ("SEVEN", "7");
			EIGHT = new Rank ("EIGHT", "8");
			NINE = new Rank ("NINE", "9");
			TEN = new Rank ("TEN", "10");
			JACK = new Rank ("JACK", "J");
			QUEEN = new Rank ("QUEEN", "Q");
			KING = new Rank ("KING", "K");
			ACE = new Rank ("ACE", "A");
		}

		public Rank (string n, string s)
		{
			name = n;
			symbol = s;
			VALUES.Add (this);
		}

		public int CompareTo(Rank OtherRankObject)
		{
			if (VALUES.IndexOf (this) == VALUES.IndexOf (OtherRankObject))
				return 0;
			else if (VALUES.IndexOf (this) < VALUES.IndexOf (OtherRankObject))
				return -1;
			else
				return 1;
		}

		public string GetSymbol()
		{
			return symbol;
		}

		public string GetName()
		{
			return name;
		}

		public override string ToString()
		{
			return name;
		}
	}
}

