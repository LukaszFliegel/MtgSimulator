using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.Cards.Interfaces;
using MtgSimulator.Domain.GameManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MtgSimulator
{
    public class PlayerSimulator
    {
        private readonly PlayerGameState _playerGameState;

        public PlayerSimulator(PlayerGameState playerGameState)
        {
            _playerGameState = playerGameState;
        }

        public void SimulateTurn()
        {
            Untap();            
            Upkeep();
            Draw();
            FirstMainPhase();
            Combat();
            SecondMainPhase();
            EndStep();
        }

        protected void Untap()
        {
            foreach (var permanent in _playerGameState.BattlefieldZone.Cards)
            {
                if (permanent is ITappable)
                    (permanent as ITappable).Untap();
            }            
        }

        protected void Upkeep()
        {

        }

        protected void Draw()
        {
            _playerGameState.Deck.DrawCard();
        }

        protected void FirstMainPhase()
        {
            //foreach (var card in _playerGameState.HandZone.Cards)
            //{
            //    if(card is Land)
            //    {
            //        var land = card as Land;
            //    }
            //}

            _playerGameState.HandZone.Cards
                .Where(card => card is Land)
                .FirstOrDefault()
                .PlayCard();
        }

        protected void Combat()
        {

        }

        protected void SecondMainPhase()
        {

        }

        protected void EndStep()
        {

        }
    }
}
