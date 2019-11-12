using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.GameManager;

namespace MtgSimulator.Cards.Creatures
{
    public class MassacreGirlCard : Creature
    {
        public MassacreGirlCard(PlayerGameState playerGameState)
            : base("Massacre Girl", playerGameState, power: 4, toughtness: 4, colorlessManaAmount: 3, ManaSymbol.Black, ManaSymbol.Black)
        {
        }
    }
}
