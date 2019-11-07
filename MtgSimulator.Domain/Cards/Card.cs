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
        }

        public abstract int Cmc();

        public abstract IEnumerable<ManaSymbol> Colors();

        public abstract void PlayCard();
    }

    public enum NonLibraryCardZone
    {
        Hand,
        Stack,
        Battlefield,
        Graveyard,
        Exile
    }
}
