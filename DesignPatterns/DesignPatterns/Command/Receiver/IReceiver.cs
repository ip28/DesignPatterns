using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    public interface IReceiver
    {
        void TurnOn();
        void TurnOff();
    }
}
