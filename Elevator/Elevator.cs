namespace Kabatra.Elevator
{
    using Car;
    using HoistMechanism;

    public class Elevator
    {
        protected readonly HoistMechanism.HoistMechanism hoistMechanism;
        protected readonly CarController carController;

        public Elevator(HoistMechanismType hoistMechanismType, List<int> floors, int startingFloor = 1, int distanceBetweenFloorsInMeters = 5)
        {
            hoistMechanism = new HoistMechanism.HoistMechanism(hoistMechanismType);
            carController = new CarController(distanceBetweenFloorsInMeters, hoistMechanism.MechanismSpeedInMetersPerSecond, floors, startingFloor);
        }

        public HoistMechanismType GetHoistMechanism()
        {
            return hoistMechanism.HoistMechanismType;
        }
    }
}