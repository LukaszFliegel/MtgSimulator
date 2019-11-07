using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;

namespace MtgSimulator.Cards.Lands
{
    public class WateryGraveCard : Land
    {
        public WateryGraveCard()
            : base("Watery Grave", entersTapped: false, ManaSymbol.Blue, ManaSymbol.Black)
        {
        }
    }
}
