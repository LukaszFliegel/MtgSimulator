using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.GameManager;

namespace MtgSimulator.Cards.Creatures
{
    public class ParadiseDruidCard : Creature
    {
        public ParadiseDruidCard(PlayerGameState playerGameState)
            : base("Paradise Druid", playerGameState, power: 2, toughtness: 1, colorlessManaAmount: 1, ManaSymbol.Green)
        {
        }
    }
}
