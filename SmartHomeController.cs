using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class SmartHomeController
    {
        public List<ISwitchable> devices = new List<ISwitchable>();
        public List<IEnergyConsumer> energyDevices = new List<IEnergyConsumer>();
        public void AddDevice(ISwitchable device)
        {
            devices.Add(device);
        }
        public void AddEnergyDevice(IEnergyConsumer device)
        {
            energyDevices.Add(device);
        }
        public void TurnAllOn()
        {
            for (int i = 0; i < devices.Count; i++)
            {
                devices[i].TurnOn();
            }
        }

        public void TurnAllOff()
        {
            for (int i = 0; i < devices.Count; i++)
            {
                devices[i].TurnOff();
            }
        }

        public void ShowEnergyReport(int hours)
        {
            Console.WriteLine($"Звіт про споживання енергії за {hours} год:");
            double totalEnergy = 0;

            for (int i = 0; i < energyDevices.Count; i++)
            {

                IEnergyConsumer currentDevice = energyDevices[i];

                double energy = currentDevice.GetEnergyUsage(hours);
                totalEnergy += energy;
                Console.WriteLine($"{currentDevice.DeviceName}: {energy:F2} кВт·год (потужність: {currentDevice.PowerConsumption} Вт)");
            }
            Console.WriteLine($"Загальне споживання: {totalEnergy:F2} кВт·год");
            Console.WriteLine($"Вартість (~4 грн/кВт·год): {totalEnergy * 4:F2} грн");
        }

    }
}
