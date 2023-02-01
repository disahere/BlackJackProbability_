using System;

namespace BlackJackProbability
{
    class Program
    {
        static void Main(string[] args)
        {
            int decksLeft = 1;
            int totalDecks = 1; 

            Console.WriteLine("Введите значение руки игрока: ");
            int playerHandValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение открытой карты дилера: ");
            int dealerUpCardValue = Convert.ToInt32(Console.ReadLine());

            double probability = CalculateProbability(totalDecks, decksLeft, playerHandValue, dealerUpCardValue);
            Console.WriteLine("Шанс на победу: {0:P2}", probability);
            Console.ReadLine();
        }

        static double CalculateProbability(int totalDecks, int decksLeft, int playerHandValue, int dealerUpCardValue)
        {
            int totalCardsLeft = (totalDecks * 52) - ((totalDecks - decksLeft) * 52);
            int cardsNeeded = 21 - playerHandValue;
            int goodCards = 0;

            for (int i = 2; i <= 11; i++)
            {
                if (i >= 10)
                {
                    goodCards += 4 * decksLeft;
                }
                else if (i >= cardsNeeded)
                {
                    goodCards += 4 * decksLeft;
                }
            }

            return (double)goodCards / totalCardsLeft;
        }
    }
}
