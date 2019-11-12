using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.GameManager;

namespace MtgSimulator.Cards.Lands
{
    public class MountainCard : Land
    {
        public MountainCard(PlayerGameState playerGameState)
            : base("Mountain", playerGameState, entersTapped: false, isBasicLand: true, ManaSymbol.Red)
        {
        }
    }
}
