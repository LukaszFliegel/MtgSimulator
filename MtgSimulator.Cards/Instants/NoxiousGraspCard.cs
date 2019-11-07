using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;

namespace MtgSimulator.Cards.Instants
{
    public class NoxiousGraspCard : Instant
    {
        public NoxiousGraspCard() 
            : base("Noxious Grasp", colorlessManaAmount: 1, ManaSymbol.Black)
        {
        }
    }
}
