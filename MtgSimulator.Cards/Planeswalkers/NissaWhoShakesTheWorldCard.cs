using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;

namespace MtgSimulator.Cards.Planeswalkers
{
    public class NissaWhoShakesTheWorldCard : Planeswalker
    {
        public NissaWhoShakesTheWorldCard()
            : base("Nissa, Who Shakes the World", loyalityCounters: 5, colorlessManaAmount: 3, ManaSymbol.Green, ManaSymbol.Green)
        {
        }
    }
}
