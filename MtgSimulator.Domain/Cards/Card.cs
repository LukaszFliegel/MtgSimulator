﻿using System;
using System.Collections.Generic;

namespace MtgSimulator.Domain.Cards
{
    public abstract class Card
    {
        public string Name { get; protected set; }

        public CardZone CardZone { get; protected set; }

        protected Card(string name)
        {
            Name = name;
            CardZone = CardZone.Library;
        }

        public abstract int Cmc();

        public abstract IEnumerable<ManaSymbol> Colors();

        public abstract void PlayCard();

        public virtual void OnDraw()
        {
            CardZone = CardZone.Hand;
        }

        public virtual void OnGraveyardHit()
        {
            CardZone = CardZone.Graveyard;
        }
    }

    public enum CardZone
    {
        Library = 0,
        Hand = 1,
        Stack,
        Battlefield,
        Graveyard,
        Exile
    }
}
