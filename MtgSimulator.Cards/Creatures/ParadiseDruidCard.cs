using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;

namespace MtgSimulator.Cards.Creatures
{
    public class ParadiseDruidCard : Creature
    {
        public ParadiseDruidCard()
            : base("Paradise Druid", power: 2, toughtness: 1, colorlessManaAmount: 1, ManaSymbol.Green)
        {
        }
    }
}
