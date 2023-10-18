using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeManagementSystem
{
    // Define an interface for controllable devices
    interface IControllable
    {
        void TurnOn();
        void TurnOff();
        bool IsOn();
    }
}
