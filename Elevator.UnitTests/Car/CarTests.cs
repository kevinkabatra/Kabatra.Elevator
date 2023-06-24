using Kabatra.Elevator.UnitTests.TestData;

namespace Kabatra.Elevator.UnitTests.Car
{
    public class CarTests
    {
        [Fact]
        public void CanCreateCar()
        {
            var car = new Kabatra.Elevator.Car.Car(GenericElevator.FloorButtons());
            Assert.NotNull(car);
            Assert.NotNull(car.Door);
            Assert.NotEmpty(car.FloorButtons);
        }
    }
}
