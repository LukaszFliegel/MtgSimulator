using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;

namespace MtgSimulator.Cards.Sorceries
{
    public class LegionsEndCard : Sorcery
    {
        public LegionsEndCard() 
            : base("Legion's End", colorlessManaAmount: 1, ManaSymbol.Black)
        {
        }
    }
}
