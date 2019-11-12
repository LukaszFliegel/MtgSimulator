using MtgSimulator.Domain.Cards.Interfaces;
using MtgSimulator.Domain.GameManager;
using System.Collections.Generic;

namespace MtgSimulator.Domain.Cards
{
    public abstract class Land: Card, IPermanent
    {
        private ManaSymbol[] GeneratesMana { get; }

        public bool Tapped { get; private set; }
        public bool IsBasicLand { get; }

        protected Land(string name, PlayerGameState playerGameState, bool entersTapped, bool isBasicLand, params ManaSymbol[] generatesMana) 
            : base(name, playerGameState)
        {
            GeneratesMana = generatesMana;
            Tapped = entersTapped;
            IsBasicLand = isBasicLand;
        }

        protected Land(string name, PlayerGameState playerGameState, bool entersTapped, params ManaSymbol[] generatesMana) 
            : base(name, playerGameState)
        {
            GeneratesMana = generatesMana;
            Tapped = entersTapped;
            IsBasicLand = false;
        }

        public override int Cmc
        {
            get { return 0; }
        }

        public override IEnumerable<ManaSymbol> Colors()
        {
            yield return ManaSymbol.Colorless;
        }

        public ManaSymbol[] GeneratesManaSymbols()
        {
            return GeneratesMana;
        }

        public void PlayLand()
        {
            PlayerGameState.HandZone.Cards.Remove(this);
            PlayerGameState.BattlefieldZone.PutPermanentOnTheBattlefield(this);
            // played land are going straight onto the battlefield, nothing to do when they are played
        }

        public virtual void OnEntersTheBattlefield()
        {
            CardZone = CardZone.Battlefield;
        }
    }
}
