using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;

namespace MtgSimulator.Cards.Lands
{
    public class TempleOfMaladyCard : Land
    {
        public TempleOfMaladyCard()
            : base("Temple of Malady", entersTapped: true, ManaSymbol.Black, ManaSymbol.Green)
        {
        }
    }
}
