using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.GameManager;

namespace MtgSimulator.Cards.Lands
{
    public class OvergrownTombCard : Land
    {
        public OvergrownTombCard(PlayerGameState playerGameState)
            : base("Overgrown Tomb", playerGameState, entersTapped: false, ManaSymbol.Black, ManaSymbol.Green)
        {
        }
    }
}
