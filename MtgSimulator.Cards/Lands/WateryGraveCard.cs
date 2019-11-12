using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.GameManager;

namespace MtgSimulator.Cards.Lands
{
    public class WateryGraveCard : Land
    {
        public WateryGraveCard(PlayerGameState playerGameState)
            : base("Watery Grave", playerGameState, entersTapped: false, ManaSymbol.Blue, ManaSymbol.Black)
        {
        }
    }
}
