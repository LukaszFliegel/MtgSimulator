using MtgSimulator.Domain.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace MtgSimulator.Domain.Zones
{
    public class GraveyardZone
    {
        public IList<Card> Cards { get; private set; }

        public GraveyardZone()
        {
            Cards = new List<Card>();
        }

        public void ClearGraveyard()
        {
            Cards.Clear();
        }

        public void PutCardToGraveyard(Card card)
        {            
            Cards.Add(card);
            card.OnGraveyardHit();
        }
    }
}
