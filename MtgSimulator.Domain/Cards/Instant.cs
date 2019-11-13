using MtgSimulator.Domain.GameManager;
using System.Collections.Generic;

namespace MtgSimulator.Domain.Cards
{
    public abstract class Instant : Spell
    {
        protected Instant(string name, PlayerGameState playerGameState, int colorlessManaAmount, params ManaSymbol[] colorManaSymbols) 
            : base(name, playerGameState, colorlessManaAmount, colorManaSymbols)
        {
        }

        public virtual void OnResolve()
        {
            CardZone = CardZone.Graveyard;
            PlayerGameState.GraveyardZone.Cards.Add(this);
        }

        public override void OnCast()
        {
            PlayerGameState.HandZone.Cards.Remove(this);
            OnResolve();
        }
    }
}
