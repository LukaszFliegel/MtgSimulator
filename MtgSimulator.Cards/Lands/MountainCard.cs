using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;

namespace MtgSimulator.Cards.Lands
{
    public class MountainCard : Land
    {
        public MountainCard()
            : base("Mountain", entersTapped: false, isBasicLand: true, ManaSymbol.Red)
        {
        }
    }
}
