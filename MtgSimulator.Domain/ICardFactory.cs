using MtgSimulator.Domain.Cards;
using MtgSimulator.Domain.GameManager;

namespace MtgSimulator.Cards
{
    public interface ICardFactory
    {
        Card InstantiateCard(string name, PlayerGameState playerGameState);
        Creature InstantiateCreature(string name, PlayerGameState playerGameState);
        Spell InstantiateSpell(string name, PlayerGameState playerGameState);
    }
}