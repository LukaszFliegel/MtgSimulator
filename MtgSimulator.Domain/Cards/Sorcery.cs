using MtgSimulator.Domain.GameManager;
using System.Collections.Generic;

namespace MtgSimulator.Domain.Cards
{
    public abstract class Sorcery : Spell
    {
        protected Sorcery(string name, PlayerGameState playerGameState, int colorlessManaAmount, params ManaSymbol[] colorManaSymbols) 
            : base(name, playerGameState, colorlessManaAmount, colorManaSymbols)
        {
        }
    }
}
