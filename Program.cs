namespace SmartHomeSystem
{
    public class Program
    {
        static void Main()
        {
            SmartHomeController controller = new SmartHomeController();
            Light light = new Light { Name = "Лампа у вітальні" };
            AirConditioner airConditioner = new AirConditioner { Name = "КОндиціонер у спальні" };
            CoffeeMachine coffeeMachine = new CoffeeMachine { Name = "Кавомашина на кухні" };
            MotionSensor motionSensor = new MotionSensor { Name = "Датчик руху у коридорі" };

            controller.AddDevice(light);
            controller.AddDevice(airConditioner);
            controller.AddDevice(coffeeMachine);
            controller.AddDevice(motionSensor);

            controller.AddEnergyDevice(light);
            controller.AddEnergyDevice(airConditioner);
            controller.AddEnergyDevice(coffeeMachine);

            controller.TurnAllOff();

            light.PrintStatus();
            airConditioner.PrintStatus();
            coffeeMachine.PrintStatus();
            motionSensor.PrintStatus();

            controller.ShowEnergyReport(5);

            controller.TurnAllOff();

        }

    }
}
