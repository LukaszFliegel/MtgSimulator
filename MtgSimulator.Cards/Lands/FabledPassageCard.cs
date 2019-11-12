using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.GameManager;

namespace MtgSimulator.Cards.Lands
{
    public class FabledPassageCard : Land
    {
        // TODO & TTA: how to handle fabled passage tappeness?
        public FabledPassageCard(PlayerGameState playerGameState)
            : base("Fabled Passage", playerGameState, entersTapped: true, ManaSymbol.Blue, ManaSymbol.Black, ManaSymbol.Green)
        {
        }
    }
}
