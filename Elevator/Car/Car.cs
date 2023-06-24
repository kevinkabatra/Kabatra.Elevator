namespace Kabatra.Elevator.Car
{
    using Buttons;

    public class Car
    {
        public readonly Door Door;
        public readonly List<FloorButton> FloorButtons;

        public Car(List<FloorButton> floorButtons)
        {
            Door = new Door();
            FloorButtons = floorButtons;
        }
    }
}
