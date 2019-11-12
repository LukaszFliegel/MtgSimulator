using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.GameManager;

namespace MtgSimulator.Cards.Lands
{
    public class PlainsCard : Land
    {
        public PlainsCard(PlayerGameState playerGameState)
            : base("Plains", playerGameState, entersTapped: false, isBasicLand: true, ManaSymbol.White)
        {
        }
    }
}
