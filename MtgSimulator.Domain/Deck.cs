using MtgSimulator.Cards;
using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.Extensions;
using MtgSimulator.Domain.GameManager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MtgSimulator.Domain
{
    public class Deck
    {
        protected IList<Card> Cards { get; set; }
        private ICardFactory _cardFactory;

        private static Random _random = new Random();

        public Deck(ICardFactory cardFactory)
        {
            _cardFactory = cardFactory;
            Cards = new List<Card>();
        }

        public void LoadFromCsv(string deckCsvFilePath, PlayerGameState playerGameState)
        {
            using(var streamReader = new StreamReader(deckCsvFilePath))
            {
                while(!streamReader.EndOfStream)
                {
                    var readLine = streamReader.ReadLine();
                    var values = readLine.Split(';');

                    var numberOfCardsInDeck = int.Parse(values[0]);
                    var cardName = values[1];
                    
                    for (int i = 0; i < numberOfCardsInDeck; i++)
                    {
                        Cards.Add(_cardFactory.InstantiateCard(cardName, playerGameState));
                    }
                }
            }
        }

        public void LoadCardByNames(IEnumerable<string> cardNames, PlayerGameState playerGameState)
        {
            foreach (var cardName in cardNames)
            {
                Cards.Add(_cardFactory.InstantiateCard(cardName, playerGameState));
            }
        }

        public void Shuffle()
        {
            Cards.Shuffle();
        }

        public Card PeekTopCard()
        {
            return Cards.First();
        }

        public Card DrawCard()
        {
            var drawnCard = Cards.First();
            Cards.Remove(drawnCard);

            return drawnCard;
        }
    }
}
