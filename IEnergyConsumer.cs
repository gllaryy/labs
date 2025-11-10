using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public interface IEnergyConsumer : ISwitchable
    {
        string DeviceName { get; }
        int PowerConsumption { get; }
        double GetEnergyUsage(int hours)
        {
            if (IsOn)
            {
                double energy = PowerConsumption * hours / 1000;
                return energy;
            }
            else
            {
                return 0;
            }
        }
    }
}
