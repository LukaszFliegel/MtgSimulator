using MtgSimulator.Cards;
using MtgSimulator.Domain.GameManager;
using System;

namespace MtgSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var csvDecklistFilePath = "..\\..\\..\\..\\Decklists\\SultaiFood.csv";
            var boardManager = new BoardManager(new CardFactory());

            var playerSimulator = new PlayerSimulator(boardManager.PlayerGameState);

            boardManager.InitializeBoardManager(csvDecklistFilePath);

            Console.WriteLine("Drawn cards:");
            foreach (var cardInHand in boardManager.PlayerGameState.HandZone.Cards)
            {
                Console.WriteLine(cardInHand.Name);
            }

            // simulate first 10 turns
            for (int i = 0; i < 10; i++)
            {
                playerSimulator.SimulateTurn();
            }
        }
    }
}
