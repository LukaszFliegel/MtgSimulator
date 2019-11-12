using MtgSimulator.Domain.Cards.Interfaces;
using MtgSimulator.Domain.GameManager;
using System.Collections.Generic;

namespace MtgSimulator.Domain.Cards
{
    public abstract class Creature : Spell, IPermanent, ITappable
    {
        public int Power { get; private set; }

        public int Toughtness { get; private set; }

        public int NumberOfPlusOnePlusOneCounters { get; private set; }

        private bool _tapped;

        protected Creature(string name, PlayerGameState playerGameState, int power, int toughtness, int colorlessManaAmount, params ManaSymbol[] colorManaSymbols) 
            : base(name, playerGameState, colorlessManaAmount, colorManaSymbols)
        {
            Power = power;
            Toughtness = toughtness;
            _tapped = false;
        }

        protected Creature(string name, PlayerGameState playerGameState, int power, int toughtness, params ManaSymbol[] colorManaSymbols)
            : base(name, playerGameState, 0, colorManaSymbols)
        {
            Power = power;
            Toughtness = toughtness;
            _tapped = false;
        }

        protected Creature(string name, PlayerGameState playerGameState, int power, int toughtness, bool usesVariantAmountCost, int minimumValueForVariantMana, params ManaSymbol[] colorManaSymbols)
            : base(name, playerGameState, usesVariantAmountCost, minimumValueForVariantMana, colorManaSymbols)
        {
            Power = power;
            Toughtness = toughtness;
            _tapped = false;
        }

        public virtual void OnEntersTheBattlefield()
        {
            CardZone = CardZone.Battlefield;
        }

        public void Tap()
        {
            _tapped = true;
        }

        public void Untap()
        {
            _tapped = false;
        }

        public bool IsTapped()
        {
            return _tapped;
        }
    }
}
