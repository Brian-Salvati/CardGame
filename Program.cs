/*
Brian Salvati
HW2
*/

using System;

namespace HW2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("CardCount or Blackjack?");
			string choice = Console.ReadLine().ToUpper();

			if(choice == "CARDCOUNT")
			{
				CardCountGame c = new CardCountGame();
				c.PlayGame ();
			}
			else if(choice == "BLACKJACK")
			{
				BlackJackGame b = new BlackJackGame ();
				b.PlayGame ();
			}
		}
	}
}