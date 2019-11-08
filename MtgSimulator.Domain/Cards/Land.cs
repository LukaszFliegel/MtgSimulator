using MtgSimulator.Domain.Cards.Interfaces;
using System.Collections.Generic;

namespace MtgSimulator.Domain.Cards
{
    public abstract class Land: Card, IPermanent
    {
        private ManaSymbol[] GeneratesMana { get; }

        public bool Tapped { get; private set; }
        public bool IsBasicLand { get; }

        protected Land(string name, bool entersTapped, bool isBasicLand, params ManaSymbol[] generatesMana) : base(name)
        {
            GeneratesMana = generatesMana;
            Tapped = entersTapped;
            IsBasicLand = isBasicLand;
        }

        protected Land(string name, bool entersTapped, params ManaSymbol[] generatesMana) : base(name)
        {
            GeneratesMana = generatesMana;
            Tapped = entersTapped;
            IsBasicLand = false;
        }

        public override int Cmc()
        {
            return 0;
        }

        public override IEnumerable<ManaSymbol> Colors()
        {
            yield return ManaSymbol.Colorless;
        }

        public ManaSymbol[] GeneratesManaSymbols()
        {
            return GeneratesMana;
        }

        public override void PlayCard()
        {
            // played land are going straight onto the battlefield, nothing to do when they are played
        }

        public virtual void OnEntersTheBattlefield()
        {
            CardZone = CardZone.Battlefield;
        }
    }
}
