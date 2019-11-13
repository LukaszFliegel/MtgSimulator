using MtgSimulator.Domain;
using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.Cards.Interfaces;
using MtgSimulator.Domain.GameManager;
using System;
using System.Linq;

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

            _playerGameState.AvailableMana.SpentManaSymbols.Clear();
            _playerGameState.AvailableMana.TotalManaSpent = 0;
        }

        protected void Upkeep()
        {

        }

        protected void Draw()
        {            
            var drawnCard = _playerGameState.Deck.DrawCard();
            Console.WriteLine($"Drawn card {drawnCard.Name}");

            _playerGameState.HandZone.AddCardToHand(drawnCard);
        }

        protected void FirstMainPhase()
        {
            // play a land for the turn
            // TODO: pick land that will make more of you hand cads playable
            var land = _playerGameState.HandZone.Cards
                .Where(card => card is Land)
                .Select(card => card as Land)
                .FirstOrDefault();

            Console.WriteLine($" ### Playing {land.Name}");
            land.PlayLand();

            Spell candidateSpell;
            do
            {
                //var availableMana = ;
                Console.WriteLine($"Available mana: {_playerGameState.AvailableMana.ToString()}");

                candidateSpell = FindSpellToCastGivenAvailableMana(_playerGameState.AvailableMana);
                if (candidateSpell != null)
                {
                    Console.WriteLine($" === Casting {candidateSpell.Name}");
                    candidateSpell.Cast(_playerGameState.AvailableMana);
                }
            }
            while (candidateSpell != null);
        }

        private Spell FindSpellToCastGivenAvailableMana(AvailableMana availableMana)
        {
            Spell candidateSpell = FindNonVariantManaSpell(availableMana);

            // if we didn't find any castable spell try to find X mana spell
            if (candidateSpell == null)
            {
                candidateSpell = FindVariantManaSpell(availableMana);
            }

            return candidateSpell;
        }

        private Spell FindNonVariantManaSpell(AvailableMana availableMana)
        {
            // select the higest CMC playable spell (omit all X mana spells)
            var spells = _playerGameState.HandZone.Cards
                .Where(card => card is Spell)
                .Select(card => card as Spell)
                .Where(spell => spell.IsCastable(availableMana))
                .Where(spell => !spell.Cost.UsesVariantAmount) // omit X mana spells
                .OrderByDescending(spell => spell.Cmc); // take highest CMC spell


            var spell2 = spells.FirstOrDefault();

            return spell2;
        }

        private Spell FindVariantManaSpell(AvailableMana availableMana)
        {
            // select the lowest CMC X mana spell (considering minimum value for variant mana spell - i.e. do not take Hydroid Krasis to cast it for x=1)
            return _playerGameState.HandZone.Cards
                .Where(card => card is Spell)
                .Select(card => card as Spell)
                .Where(spell => spell.IsCastable(availableMana))
                .Where(spell => spell.Cost.UsesVariantAmount) // only X mana spells
                .Where(spell => spell.Cost.MinimumValueForVariantMana + spell.Cmc <= availableMana.TotalAmountOfMana) // take only spells that are worth casting (ex. Hydroid Krasis for x=1 is not worth casting)
                .OrderBy(spell => spell.Cmc) // take the spell with lowest CMC (i.e. preferr to cast Hydroid Krasis before Mass Manipulation)
                .FirstOrDefault();
        }

        protected void Combat()
        {

        }

        protected void SecondMainPhase()
        {

        }

        protected void EndStep()
        {
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
