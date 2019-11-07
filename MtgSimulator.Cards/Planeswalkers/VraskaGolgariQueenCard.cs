using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;

namespace MtgSimulator.Cards.Planeswalkers
{
    public class VraskaGolgariQueenCard : Planeswalker
    {
        public VraskaGolgariQueenCard()
            : base("Vraska, Golgari Queen", loyalityCounters: 4, colorlessManaAmount: 2, ManaSymbol.Blue, ManaSymbol.Black)
        {
        }
    }
}
