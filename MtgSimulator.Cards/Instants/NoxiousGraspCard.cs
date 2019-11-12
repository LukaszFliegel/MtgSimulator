using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.GameManager;

namespace MtgSimulator.Cards.Instants
{
    public class NoxiousGraspCard : Instant
    {
        public NoxiousGraspCard(PlayerGameState playerGameState) 
            : base("Noxious Grasp", playerGameState, colorlessManaAmount: 1, ManaSymbol.Black)
        {
        }
    }
}
