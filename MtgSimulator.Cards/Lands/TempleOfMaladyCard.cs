using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.GameManager;

namespace MtgSimulator.Cards.Lands
{
    public class TempleOfMaladyCard : Land
    {
        public TempleOfMaladyCard(PlayerGameState playerGameState)
            : base("Temple of Malady", playerGameState, entersTapped: true, ManaSymbol.Black, ManaSymbol.Green)
        {
        }
    }
}
