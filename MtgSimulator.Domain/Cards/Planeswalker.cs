using MtgSimulator.Domain.Cards.Interfaces;
using MtgSimulator.Domain.GameManager;
using System.Collections.Generic;

namespace MtgSimulator.Domain.Cards
{
    public abstract class Planeswalker : Spell, IPermanent
    {
        public int LoyalityCounters { get; set; }

        public bool Tapped => false;

        protected Planeswalker(string name, PlayerGameState playerGameState, int loyalityCounters, int colorlessManaAmount, params ManaSymbol[] colorManaSymbols) 
            : base(name, playerGameState, colorlessManaAmount, colorManaSymbols)
        {
            LoyalityCounters = loyalityCounters;
        }

        public virtual void OnEntersTheBattlefield()
        {
            CardZone = CardZone.Battlefield;
        }

        public override void OnCast()
        {
            PlayerGameState.HandZone.Cards.Remove(this);
            OnEntersTheBattlefield();
        }
    }
}
