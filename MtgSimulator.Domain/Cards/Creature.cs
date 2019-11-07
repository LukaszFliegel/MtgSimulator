using System.Collections.Generic;

namespace MtgSimulator.Domain.Cards
{
    public abstract class Creature : Spell, IPermanent
    {
        public int Power { get; private set; }

        public int Toughtness { get; private set; }

        public int NumberOfPlusOnePlusOneCounters { get; private set; }
        public bool Tapped { get; private set; }

        protected Creature(string name, int power, int toughtness, int colorlessManaAmount, params ManaSymbol[] colorManaSymbols) 
            : base(name, colorlessManaAmount, colorManaSymbols)
        {
            Power = power;
            Toughtness = toughtness;
            Tapped = false;
        }

        protected Creature(string name, int power, int toughtness, params ManaSymbol[] colorManaSymbols)
            : base(name, 0, colorManaSymbols)
        {
            Power = power;
            Toughtness = toughtness;
            Tapped = false;
        }

        protected Creature(string name, int power, int toughtness, bool usesVariantAmount, params ManaSymbol[] colorManaSymbols)
            : base(name, usesVariantAmount, colorManaSymbols)
        {
            Power = power;
            Toughtness = toughtness;
            Tapped = false;
        }
    }
}
