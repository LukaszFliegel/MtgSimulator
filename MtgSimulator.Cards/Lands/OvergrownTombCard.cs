using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;

namespace MtgSimulator.Cards.Lands
{
    public class OvergrownTombCard : Land
    {
        public OvergrownTombCard()
            : base("Overgrown Tomb", entersTapped: false, ManaSymbol.Black, ManaSymbol.Green)
        {
        }
    }
}
