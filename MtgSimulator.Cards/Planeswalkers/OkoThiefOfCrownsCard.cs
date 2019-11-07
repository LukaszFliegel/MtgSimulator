using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;

namespace MtgSimulator.Cards.Planeswalkers
{
    public class OkoThiefOfCrownsCard : Planeswalker
    {
        public OkoThiefOfCrownsCard()
            : base("Oko, Thief of Crowns", loyalityCounters: 4, colorlessManaAmount: 1, ManaSymbol.Blue, ManaSymbol.Green)
        {
        }
    }
}
