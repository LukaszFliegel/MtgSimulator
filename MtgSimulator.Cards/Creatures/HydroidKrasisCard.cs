using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;

namespace MtgSimulator.Cards.Creatures
{
    public class HydroidKrasisCard : Creature
    {
        public HydroidKrasisCard() 
            : base("Hydroid Krasis", power: 0, toughtness: 0, usesVariantAmountCost: true, ManaSymbol.Blue, ManaSymbol.Green)
        {
        }
    }
}
