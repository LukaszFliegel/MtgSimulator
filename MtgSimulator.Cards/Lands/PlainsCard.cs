using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;

namespace MtgSimulator.Cards.Lands
{
    public class PlainsCard : Land
    {
        public PlainsCard()
            : base("Plains", entersTapped: false, isBasicLand: true, ManaSymbol.White)
        {
        }
    }
}
