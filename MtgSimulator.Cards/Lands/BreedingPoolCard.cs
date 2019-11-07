using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;

namespace MtgSimulator.Cards.Lands
{
    public class BreedingPoolCard : Land
    {
        public BreedingPoolCard() 
            : base("Breeding Pool", entersTapped: false, ManaSymbol.Blue, ManaSymbol.Green)
        {
        }
    }
}
