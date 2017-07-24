/*
Brian Salvati
HW2
*/

using System;
using System.Collections.Generic;

namespace HW2
{
	public abstract class Hand
	{
		public List<Card> hand;

		public Hand ()
		{
			hand = new List<Card> ();
		}

		public void AddCard(Card c)
		{
			hand.Add (c);
		}

		abstract public int CompareTo (Hand OtherHandObject);

		public bool ContainsCard(Card c)
		{
			foreach (Card card in hand) 
			{
				if (card.CompareTo(c) == 0)
					return true;
			}
			return false;
		}

		public void DiscardHand()
		{
			foreach (Card c in hand) 
			{
				hand.Remove (c);
			}
		}

		public int FindCard(Card c)
		{
			int n = 0;
			bool first = false;  //ensures returning first occurence
			for (int i = 0; i < hand.Count; i++) 
			{
				if (c.CompareTo (hand [i]) == 0) 
				{
					n = i;
					first = true;
				}
				if (first)
					break;
			}
			return n;				
		}

		public Card GetCardAtIndex(int i)
		{
			return hand [i];
		}

		public int GetNumberOfCards()
		{
			return hand.Count;
		}

		public bool IsEmpty()
		{
			if (hand.Count == 0)
				return true;
			else
				return false;
		}

		//removes first occurrence of specified card
		public Card RemoveCard(Card c)
		{
			Card anotherCard;
			foreach (Card card in hand) 
			{
				if (card.CompareTo (c) == 0) 
				{
					anotherCard = c;
					hand.Remove (c);
					return anotherCard;
				}
			}
			return null;
		}

		//removes card at specified index
		public Card RemoveCard(int i)
		{
			Card c = hand [i];
			hand.Remove (c);
			return c;
		}

		abstract public int EvaluateHand();

		public override string ToString()
		{
			string cards = "";
			foreach (Card c in hand) 
				cards = cards + " " + c.ToString ();
			return cards;
		}
	}
}

