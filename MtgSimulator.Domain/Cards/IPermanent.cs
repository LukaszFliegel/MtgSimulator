using System;
using System.Collections.Generic;
using System.Text;

namespace MtgSimulator.Domain.Cards
{
    public interface IPermanent
    {
        public bool Tapped { get; }
    }
}
