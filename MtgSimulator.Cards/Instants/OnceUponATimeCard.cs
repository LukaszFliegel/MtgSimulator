using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;

namespace MtgSimulator.Cards.Instants
{
    public class OnceUponATimeCard : Instant
    {
        public OnceUponATimeCard()
            : base("Once Upon a Time", colorlessManaAmount: 1, ManaSymbol.Green)
        {
        }
    }
}
