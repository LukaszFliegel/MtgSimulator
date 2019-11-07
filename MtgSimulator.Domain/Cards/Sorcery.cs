using System.Collections.Generic;

namespace MtgSimulator.Domain.Cards
{
    public abstract class Sorcery : Spell
    {
        protected Sorcery(string name, int colorlessManaAmount, params ManaSymbol[] colorManaSymbols) 
            : base(name, colorlessManaAmount, colorManaSymbols)
        {
        }
    }
}
