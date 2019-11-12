using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.GameManager;

namespace MtgSimulator.Cards.Lands
{
    public class SwampCard : Land
    {
        public SwampCard(PlayerGameState playerGameState)
            : base("Swamp", playerGameState, entersTapped: false, isBasicLand: true, ManaSymbol.Black)
        {
        }
    }
}
