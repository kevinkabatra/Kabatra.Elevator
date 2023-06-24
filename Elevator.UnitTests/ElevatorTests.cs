namespace Kabatra.Elevator.UnitTests
{
    using Kabatra.Elevator.HoistMechanism;
    using Kabatra.Elevator.UnitTests.TestData;

    public class ElevatorTests
    {
        [Fact]
        public void CanCreateElevator()
        {
            var elevator = new Elevator(HoistMechanismType.Traction, GenericElevator.Floors);
            Assert.NotNull(elevator);
            Assert.Equal(HoistMechanismType.Traction, elevator.GetHoistMechanism());
        }
    }
}
