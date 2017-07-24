/*
Brian Salvati
HW2
*/

using System;
using System.Collections.Generic;

namespace HW2
{
	public class CardCountHand : Hand
	{
		public CardCountHand ()
		{
		}

		public override int CompareTo(Hand OtherHandObject)
		{
			if (this.EvaluateHand () == OtherHandObject.EvaluateHand ())
				return 0;
			else if (this.EvaluateHand () < OtherHandObject.EvaluateHand ())
				return -1;
			return 1;
		}

		public override int EvaluateHand()
		{
			int count = 0;
			foreach (Card c in hand) 
			{
				if (c.GetRank() == Rank.ACE)
					count += 1;
				else if (c.GetRank() == Rank.TWO)
					count += 2;
				else if (c.GetRank() == Rank.THREE)
					count += 3;
				else if (c.GetRank() == Rank.FOUR)
					count += 4;
				else if (c.GetRank() == Rank.FIVE)
					count += 5;
				else if (c.GetRank() == Rank.SIX)
					count += 6;
				else if (c.GetRank() == Rank.SEVEN)
					count += 7;
				else if (c.GetRank() == Rank.EIGHT)
					count += 8;
				else if (c.GetRank() == Rank.NINE)
					count += 9;
				else if (c.GetRank() == Rank.TEN)
					count += 10;
				else if (c.GetRank() == Rank.JACK)
					count += 10;
				else if (c.GetRank() == Rank.QUEEN)
					count += 10;
				else if (c.GetRank() == Rank.KING)
					count += 10;
			}
			return count;
		}
	}
}

