using System;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Player kevin = new Player("Kevin");
            deck.Shuffle();

            kevin.Draw(deck, kevin);
            kevin.Draw(deck, kevin);

            System.Console.WriteLine(kevin.Hand);

        }
    }
}
