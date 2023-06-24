namespace Kabatra.Elevator.UnitTests.TestData
{
    using Buttons;
    using Kabatra.Elevator.HoistMechanism;

    public class GenericElevator
    {
        public static readonly int DistanceBetweenFloorsInMeters = 5;
        public static readonly HoistMechanism HoistMechanism = new(HoistMechanismType.Traction);

        public static readonly List<int> Floors = new()
        {
            1,2
        };

        public static List<FloorButton> FloorButtons()
        {
            var buttons = new List<FloorButton>();
            Floors.ForEach(floor =>
            {
                buttons.Add(new FloorButton(floor));
            });

            return buttons;
        }
    }
}
