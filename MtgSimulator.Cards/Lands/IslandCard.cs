using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;

namespace MtgSimulator.Cards.Lands
{
    public class IslandCard : Land
    {
        public IslandCard()
            : base("Island", entersTapped: false, isBasicLand: true, ManaSymbol.Blue)
        {
        }
    }
}
