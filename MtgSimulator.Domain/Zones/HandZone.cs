using MtgSimulator.Domain.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace MtgSimulator.Domain.Zones
{
    public class HandZone
    {
        //private const int numberOfStartingCards = 7;

        public IList<Card> Cards { get; private set; }

        public HandZone()
        {
            Cards = new List<Card>();
        }

        public void AddCardToHand(Card card)
        {            
            Cards.Add(card);
        }

        public void ClearHand()
        {
            Cards.Clear();
        }

        //public void DrawCardFromDeck()
        //{
        //    var drawnCard = _deck.DrawCard();
        //    drawnCard.OnDraw();
        //    Cards.Add(drawnCard);
        //}

        //public void DrawOpeningHand()
        //{
        //    for (int i = 0; i < numberOfStartingCards; i++)
        //    {
        //        DrawCardFromDeck();
        //    }            
        //}
    }
}
