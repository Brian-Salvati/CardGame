/*
Brian Salvati
HW2
*/

using System;

namespace HW2
{
	public class Card
	{
		readonly Suit suit;
		readonly Rank rank;

		public Card (Suit s, Rank r)
		{
			suit = s;
			rank = r;
		}

		public int CompareTo(Card OtherCardObject)
		{
			if ((this.rank).CompareTo (OtherCardObject.rank) == 0)
				return (this.suit).CompareTo (OtherCardObject.GetSuit());
			return ((this.rank).CompareTo (OtherCardObject.rank));
		}

		public Rank GetRank()
		{
			return rank;
		}

		public Suit GetSuit()
		{
			return suit;
		}

		public override string ToString()
		{
			return rank + " of " + suit + ",";
		}
	}
}

