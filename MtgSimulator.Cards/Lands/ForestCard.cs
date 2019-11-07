using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;

namespace MtgSimulator.Cards.Lands
{
    public class ForestCard : Land
    {
        public ForestCard()
            : base("Forest", entersTapped: false, isBasicLand: true, ManaSymbol.Green)
        {
        }
    }
}
