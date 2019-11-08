using MtgSimulator.Cards;
using MtgSimulator.Domain.GameManager;
using System;

namespace MtgSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            BoardManager boardManager = new BoardManager("..\\..\\..\\..\\Decklists\\SultaiFood.csv", new CardFactory());

            boardManager.InitializeBoardManager();

            Console.WriteLine("Drawn cards:");
            foreach (var cardInHand in boardManager.PlayerGameState.HandZone.Cards)
            {
                Console.WriteLine(cardInHand.Name);
            }
        }
    }
}
