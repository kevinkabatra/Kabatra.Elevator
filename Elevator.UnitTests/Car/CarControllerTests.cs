namespace Kabatra.Elevator.UnitTests.Car
{
    using Kabatra.Elevator.Car;
    using Kabatra.Elevator.UnitTests.TestData;

    public class CarControllerTests
    {
        [Fact]
        public void CanCreateCarController()
        {
            var carController = new CarController(
                GenericElevator.DistanceBetweenFloorsInMeters,
                GenericElevator.HoistMechanism.MechanismSpeedInMetersPerSecond,
                GenericElevator.Floors
            );
            Assert.NotNull(carController);
        }

        #region Floor Tests
        [Fact]
        public void CanCreateCarControllerDefaultFloor()
        {
            var carController = new CarController(
                GenericElevator.DistanceBetweenFloorsInMeters,
                GenericElevator.HoistMechanism.MechanismSpeedInMetersPerSecond,
                GenericElevator.Floors
            );
            Assert.Equal(1, carController.GetFloor());
        }
        
        [Fact]
        public void CanCreateCarControllerSpecifiedFloor()
        {
            var expectedFloor = 0;
            var carController = new CarController(
                GenericElevator.DistanceBetweenFloorsInMeters,
                GenericElevator.HoistMechanism.MechanismSpeedInMetersPerSecond,
                GenericElevator.Floors,
                expectedFloor
            );
            Assert.Equal(expectedFloor, carController.GetFloor());
        }

        [Fact]
        public async void CanSetFloor()
        {
            var expectedFloor = 2;
            var carController = new CarController(
                GenericElevator.DistanceBetweenFloorsInMeters,
                GenericElevator.HoistMechanism.MechanismSpeedInMetersPerSecond,
                GenericElevator.Floors
            );
            await carController.PushButton(expectedFloor);
            Assert.Equal(expectedFloor, carController.GetFloor());
        }
        #endregion

        #region Door Tests
        [Fact]
        public void CanGetCarDoorStatus()
        {
            var carController = new CarController(
                GenericElevator.DistanceBetweenFloorsInMeters,
                GenericElevator.HoistMechanism.MechanismSpeedInMetersPerSecond,
                GenericElevator.Floors
            );

            var expectedCarStatus = DoorStatus.Closed;
            var actualCarStatus = carController.GetDoorStatus();

            Assert.Equal(expectedCarStatus, actualCarStatus);
        }

        [Fact]
        public void CanOpenDoors()
        {
            var carController = new CarController(
                GenericElevator.DistanceBetweenFloorsInMeters,
                GenericElevator.HoistMechanism.MechanismSpeedInMetersPerSecond,
                GenericElevator.Floors
            );
            carController.OpenDoors();

            Assert.Equal(DoorStatus.Open, carController.GetDoorStatus());
        }

        [Fact]
        public void CanCloseDoors()
        {
            var carController = new CarController(
                GenericElevator.DistanceBetweenFloorsInMeters,
                GenericElevator.HoistMechanism.MechanismSpeedInMetersPerSecond,
                GenericElevator.Floors
            );
            carController.CloseDoors();

            Assert.Equal(DoorStatus.Closed, carController.GetDoorStatus());
        }
        #endregion
    }
}
