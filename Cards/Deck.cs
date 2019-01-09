using System;
using System.Collections.Generic;

namespace Cards
{
    public class Deck
    {
        string[] stringCards = new string[]
        {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};

        string[] suits = new string[]
        {
            "Clubs",
            "Spades",
            "Hearts",
            "Diamonds"
        };
        public List<Card> DeckOfCards = new List<Card>();

        public Deck()
        {
            foreach(string suit in suits)
            {
                int numVal = 1;
                foreach(var stringVal in stringCards)
                {
                    Card newCard = new Card(stringVal, suit, numVal);
                    DeckOfCards.Add(newCard);
                    numVal++;
                }
            }
        }
        public void ReadDeck()
        {
            foreach (Card card in DeckOfCards)
            {
                System.Console.WriteLine($"{card.StringVal} of {card.Suit}");
            }
        }
        public void Shuffle()
        {
            System.Console.WriteLine("---Shuffling---");
            Random random = new Random();
            for (int i = 0; i < DeckOfCards.Count; i++)
            {
                int newIndex = random.Next(DeckOfCards.Count);
                Card temp = DeckOfCards[i];
                DeckOfCards[i] = DeckOfCards[newIndex];
                DeckOfCards[newIndex] = temp;
            }
        }
        public Card Deal()
        {
            Card dealtCard = DeckOfCards[0];
            DeckOfCards.Remove(dealtCard);
            System.Console.WriteLine("---Dealing---");
            System.Console.WriteLine(dealtCard.StringVal + " of " + dealtCard.Suit);
            System.Console.WriteLine("------------------");
            return dealtCard;
        }
        public void Reset()
        {
            System.Console.WriteLine("----Resetting----");
            DeckOfCards.Clear();
            foreach (string suit in suits)
            {
                int numVal = 1;
                foreach (var stringVal in stringCards)
                {
                    Card newCard = new Card(stringVal, suit, numVal);
                    DeckOfCards.Add(newCard);
                    numVal++;
                }
            }
        }
    }
}