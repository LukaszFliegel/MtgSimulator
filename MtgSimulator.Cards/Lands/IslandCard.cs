using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.GameManager;

namespace MtgSimulator.Cards.Lands
{
    public class IslandCard : Land
    {
        public IslandCard(PlayerGameState playerGameState)
            : base("Island", playerGameState, entersTapped: false, isBasicLand: true, ManaSymbol.Blue)
        {
        }
    }
}
