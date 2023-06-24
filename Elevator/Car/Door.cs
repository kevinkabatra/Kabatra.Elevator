namespace Kabatra.Elevator.Car
{
    public class Door
    {
        public DoorStatus Status { get; private set; }

        public Door()
        {
            Status = DoorStatus.Closed;
        }

        public void OpenDoors()
        {
            if (Status == DoorStatus.Closed)
            {
                Status = DoorStatus.Open;
            }
        }

        public void CloseDoors()
        {
            if (Status == DoorStatus.Open)
            {
                Status = DoorStatus.Closed;
            }
        }
    }
}
