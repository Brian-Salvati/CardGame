/*
Brian Salvati
HW2
*/

using System;

namespace HW2
{
	public class BlackJackGame
	{
		BlackJackHand hand1 = new BlackJackHand();
		BlackJackHand hand2 = new BlackJackHand();
		Deck deck = new Deck();

		public BlackJackGame ()
		{
		}

		public void PlayGame()
		{
			Card c;
			for (int i = 0; i < 6; i++) {
				foreach (Rank r in Rank.VALUES) {
					foreach (Suit s in Suit.VALUES) {
						c = new Card (s, r);
						deck.AddCard (c);
					}
				}
			}

			deck.Shuffle ();

			string choice;
			bool p1 = true;
			Card dealt;

			do {
				if (hand1.EvaluateHand () > 21)
				{
					Console.WriteLine("Player 1 Loses");
					p1 = false;
					break;
				}
				else
				{
					dealt = deck.DealOne();
					hand1.AddCard (dealt);
					Console.WriteLine(dealt.ToString());
				}
				Console.WriteLine ("Hit or Stand");
				choice = Console.ReadLine ().ToUpper();
			} while (choice == "HIT");

			bool p2 = true;
			Card deal;

			while (hand2.EvaluateHand () < 17) 
			{
				deal = deck.DealOne ();
				hand2.AddCard (deal);
				Console.WriteLine (deal.ToString ());
				if (hand2.EvaluateHand () > 21) 
				{
					Console.WriteLine ("Player 2 loses");
					p2 = false;
				}
			}

			if (p1 == true && p2 == false)
				Console.WriteLine ("Player 1 wins!");
			if (p2 == true && p1 == false)
				Console.WriteLine ("Player 2 wins!");

			if (p1 == true && p2 == true) 
			{
				if ((hand1.CompareTo (hand2)) == 0)
					Console.WriteLine ("It's a tie!");
				else if ((hand1.CompareTo (hand2)) == -1)
					Console.WriteLine ("Player 2 wins!");
				else
					Console.WriteLine ("Player 1 wins!");
			}
		}
	}
}
