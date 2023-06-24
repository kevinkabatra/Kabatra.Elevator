using Kabatra.Elevator.Car;

namespace Kabatra.Elevator.UnitTests.Car
{
    public class DoorTests
    {
        [Fact]
        public void CanCreateDoor()
        {
            var door = new Door();
            Assert.NotNull(door);
            Assert.Equal(DoorStatus.Closed, door.Status);
        }

        [Fact]
        public void CanOpenDoors()
        {
            var door = new Door();
            door.OpenDoors();
            Assert.Equal(DoorStatus.Open, door.Status);
        }

        [Fact]
        public void CanCloseDoors()
        {
            var door = new Door();
            door.CloseDoors();
            Assert.Equal(DoorStatus.Closed, door.Status);
        }
    }
}
