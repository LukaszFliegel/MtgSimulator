using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.GameManager;

namespace MtgSimulator.Cards.Sorceries
{
    public class LegionsEndCard : Sorcery
    {
        public LegionsEndCard(PlayerGameState playerGameState) 
            : base("Legion's End", playerGameState, colorlessManaAmount: 1, ManaSymbol.Black)
        {
        }
    }
}
