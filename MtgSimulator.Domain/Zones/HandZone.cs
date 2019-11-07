using MtgSimulator.Domain.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace MtgSimulator.Domain.Zones
{
    public class HandZone
    {
        public IList<Card> Cards { get; private set; }

        public HandZone()
        {

        }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }
    }
}
