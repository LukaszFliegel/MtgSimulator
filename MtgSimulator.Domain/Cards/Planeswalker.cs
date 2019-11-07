using System.Collections.Generic;

namespace MtgSimulator.Domain.Cards
{
    public abstract class Planeswalker : Spell, IPermanent
    {
        public int LoyalityCounters { get; set; }

        public bool Tapped => false;

        protected Planeswalker(string name, int loyalityCounters, int colorlessManaAmount, params ManaSymbol[] colorManaSymbols) 
            : base(name, colorlessManaAmount, colorManaSymbols)
        {
            LoyalityCounters = loyalityCounters;
        }
    }
}
