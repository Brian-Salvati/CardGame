/*
Brian Salvati
HW2
*/

using System;
using System.Collections.Generic;

namespace HW2
{
	public class Deck
	{
		private List<Card> deck;
		private int fullDeck = 0;
		private List<Card> discarded = new List<Card>();

		public Deck ()
		{
			deck = new List<Card>();
		}

		public void AddCard(Card c)
		{
			deck.Add(c);
			fullDeck++;
		}

		public Card DealOne()
		{
			Card c = deck [0];
			deck.Remove (c);
			discarded.Add (c);
			return c;
		}

		public int GetCardsRemaining()
		{
			return deck.Count;
		}

		public int GetDeckSize()
		{
			return fullDeck;
		}

		public bool IsEmpty()
		{
			if (deck.Count == 0)
				return true;
			else
				return false;
		}

		public void Shuffle()
		{
			Random r = new Random();
			for (int i = deck.Count-1; i > 0; i--) 
			{
				int n = r.Next (i);
				Card m = deck [i];
				deck [i] = deck [n];
				deck [n] = m;
			}
		}

		public void RestoreDeck()
		{
			foreach (Card c in discarded) 
			{
				deck.Add (c);
				discarded.Remove (c);
			}
		}
	}
}

