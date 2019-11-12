using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.GameManager;

namespace MtgSimulator.Cards.Lands
{
    public class ForestCard : Land
    {
        public ForestCard(PlayerGameState playerGameState)
            : base("Forest", playerGameState, entersTapped: false, isBasicLand: true, ManaSymbol.Green)
        {
        }
    }
}
