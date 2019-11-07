using System;
using System.Collections.Generic;

namespace MtgSimulator.Domain.Cards
{
    public abstract class Card
    {
        public string Name { get; protected set; }

        public NonLibraryCardZone CardZone { get; protected set; }

        protected Card(string name)
        {
            Name = name;
            CardZone = NonLibraryCardZone.Library;
        }

        public abstract int Cmc();

        public abstract IEnumerable<ManaSymbol> Colors();

        public abstract void PlayCard();

        public virtual void OnDraw()
        {
            CardZone = NonLibraryCardZone.Hand;
        }

        public virtual void OnGraveyardHit()
        {
            CardZone = NonLibraryCardZone.Graveyard;
        }
    }

    public enum NonLibraryCardZone
    {
        Library = 0,
        Hand = 1,
        Stack,
        Battlefield,
        Graveyard,
        Exile
    }
}
