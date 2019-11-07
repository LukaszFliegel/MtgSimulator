using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;

namespace MtgSimulator.Cards.Lands
{
    public class SwampCard : Land
    {
        public SwampCard()
            : base("Swamp", entersTapped: false, isBasicLand: true, ManaSymbol.Black)
        {
        }
    }
}
