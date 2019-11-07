using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;

namespace MtgSimulator.Cards.Creatures
{
    public class MassacreGirlCard : Creature
    {
        public MassacreGirlCard()
            : base("Massacre Girl", power: 4, toughtness: 4, colorlessManaAmount: 3, ManaSymbol.Black, ManaSymbol.Black)
        {
        }
    }
}
