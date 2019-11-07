using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;

namespace MtgSimulator.Cards.Creatures
{
    public class WickedWolfCard : Creature
    {
        public WickedWolfCard()
            : base("Wicked Wolf", power: 3, toughtness: 3, colorlessManaAmount: 2, ManaSymbol.Green, ManaSymbol.Green)
        {
        }
    }
}
