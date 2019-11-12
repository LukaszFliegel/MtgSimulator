using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.GameManager;

namespace MtgSimulator.Cards.Planeswalkers
{
    public class NissaWhoShakesTheWorldCard : Planeswalker
    {
        public NissaWhoShakesTheWorldCard(PlayerGameState playerGameState)
            : base("Nissa, Who Shakes the World", playerGameState, loyalityCounters: 5, colorlessManaAmount: 3, ManaSymbol.Green, ManaSymbol.Green)
        {
        }
    }
}
