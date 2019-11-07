using System.Collections.Generic;

namespace MtgSimulator.Domain.Cards
{
    public abstract class Instant : Spell
    {
        protected Instant(string name, int colorlessManaAmount, params ManaSymbol[] colorManaSymbols) 
            : base(name, colorlessManaAmount, colorManaSymbols)
        {
        }
    }
}
