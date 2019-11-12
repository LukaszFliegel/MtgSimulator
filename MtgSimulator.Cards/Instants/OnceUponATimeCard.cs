using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.GameManager;

namespace MtgSimulator.Cards.Instants
{
    public class OnceUponATimeCard : Instant
    {
        public OnceUponATimeCard(PlayerGameState playerGameState)
            : base("Once Upon a Time", playerGameState, colorlessManaAmount: 1, ManaSymbol.Green)
        {
        }
    }
}
