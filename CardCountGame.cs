/*
Brian Salvati
HW2
*/

using System;

namespace HW2
{
	public class CardCountGame
	{
		CardCountHand hand1 = new CardCountHand();
		CardCountHand hand2 = new CardCountHand();
		Deck deck = new Deck();

		public CardCountGame ()
		{
		}

		public void PlayGame()
		{
			Card c;
			foreach (Rank r in Rank.VALUES) 
			{
				foreach (Suit s in Suit.VALUES) 
				{
					c = new Card (s, r);
					deck.AddCard(c);
				}
			}

			deck.Shuffle ();

			for (int i = 0; i < 8; i++) 
			{
				hand1.AddCard (deck.DealOne ());
				hand2.AddCard (deck.DealOne ());
			}

			Console.WriteLine ("Hand 1: " + hand1.ToString ());
			Console.WriteLine ("Hand 2: " + hand2.ToString ());

			Console.WriteLine ("Hand 1 evaluation: " + hand1.EvaluateHand ());
			Console.WriteLine ("Hand 2 evaluation: " + hand2.EvaluateHand ());

			Console.WriteLine ("Cards remaining: " + deck.GetCardsRemaining ());
		}
	}
}

