using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.GameManager;

namespace MtgSimulator.Cards.Planeswalkers
{
    public class LilianaDreadhordeGeneralCard : Planeswalker
    {
        public LilianaDreadhordeGeneralCard(PlayerGameState playerGameState)
            : base("Liliana, Dreadhorde General", playerGameState, loyalityCounters: 6, colorlessManaAmount: 4, ManaSymbol.Black, ManaSymbol.Black)
        {
        }
    }
}
