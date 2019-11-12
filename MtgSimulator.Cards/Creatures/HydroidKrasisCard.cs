using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.GameManager;

namespace MtgSimulator.Cards.Creatures
{
    public class HydroidKrasisCard : Creature
    {
        public HydroidKrasisCard(PlayerGameState playerGameState) 
            : base("Hydroid Krasis", playerGameState, power: 0, toughtness: 0, usesVariantAmountCost: true, minimumValueForVariantMana: 2, ManaSymbol.Blue, ManaSymbol.Green)
        {
        }
    }
}
