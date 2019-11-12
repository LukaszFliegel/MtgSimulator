using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.GameManager;

namespace MtgSimulator.Cards.Lands
{
    public class BreedingPoolCard : Land
    {
        public BreedingPoolCard(PlayerGameState playerGameState) 
            : base("Breeding Pool", playerGameState, entersTapped: false, ManaSymbol.Blue, ManaSymbol.Green)
        {
        }
    }
}
