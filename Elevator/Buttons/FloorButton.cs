namespace Kabatra.Elevator.Buttons
{
    public class FloorButton
    {
        public bool IsButtonIlluminated;
        public readonly int FloorAssignedToButton;

        public FloorButton(int floorAssignedToButton)
        {
            FloorAssignedToButton = floorAssignedToButton;
        }
    }
}
