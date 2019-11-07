using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;

namespace MtgSimulator.Cards.Planeswalkers
{
    public class LilianaDreadhordeGeneralCard : Planeswalker
    {
        public LilianaDreadhordeGeneralCard()
            : base("Liliana, Dreadhorde General", loyalityCounters: 6, colorlessManaAmount: 4, ManaSymbol.Black, ManaSymbol.Black)
        {
        }
    }
}
