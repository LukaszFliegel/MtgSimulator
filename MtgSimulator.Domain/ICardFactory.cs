using MtgSimulator.Domain.Cards;

namespace MtgSimulator.Cards
{
    public interface ICardFactory
    {
        Card InstantiateCard(string name);
    }
}