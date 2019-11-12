using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.GameManager;

namespace MtgSimulator.Cards.Planeswalkers
{
    public class OkoThiefOfCrownsCard : Planeswalker
    {
        public OkoThiefOfCrownsCard(PlayerGameState playerGameState)
            : base("Oko, Thief of Crowns", playerGameState, loyalityCounters: 4, colorlessManaAmount: 1, ManaSymbol.Blue, ManaSymbol.Green)
        {
        }
    }
}
