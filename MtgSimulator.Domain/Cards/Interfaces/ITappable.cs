using System;
using System.Collections.Generic;
using System.Text;

namespace MtgSimulator.Domain.Cards.Interfaces
{
    public interface ITappable
    {
        void Tap();

        void Untap();

        bool IsTapped();
    }
}
