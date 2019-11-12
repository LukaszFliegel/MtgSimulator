using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.GameManager;

namespace MtgSimulator.Cards.Planeswalkers
{
    public class VraskaGolgariQueenCard : Planeswalker
    {
        public VraskaGolgariQueenCard(PlayerGameState playerGameState)
            : base("Vraska, Golgari Queen", playerGameState, loyalityCounters: 4, colorlessManaAmount: 2, ManaSymbol.Blue, ManaSymbol.Black)
        {
        }
    }
}
