using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.GameManager;

namespace MtgSimulator.Cards.Creatures
{
    public class WickedWolfCard : Creature
    {
        public WickedWolfCard(PlayerGameState playerGameState)
            : base("Wicked Wolf", playerGameState, power: 3, toughtness: 3, colorlessManaAmount: 2, ManaSymbol.Green, ManaSymbol.Green)
        {
        }
    }
}
