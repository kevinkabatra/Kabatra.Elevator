namespace Kabatra.Elevator.Car
{
    using Buttons;

    public class CarController
    {
        private readonly Car _car;
        private readonly List<int> _floors;
        private int _currentFloor;
        private readonly int _timeToTraverseFloorsInMilliseconds;

        public CarController(decimal distanceBetweenFloorsInMeters, decimal mechanismSpeedInMetersPerSecond, List<int> floors, int currentFloor = 1)
        {
            _timeToTraverseFloorsInMilliseconds = (int)(distanceBetweenFloorsInMeters / mechanismSpeedInMetersPerSecond * 1000);
            _currentFloor = currentFloor;
            _floors = floors;
            
            var floorButtons = CreateFloorButtons();
            _car = new Car(floorButtons);
        }

        public void OpenDoors()
        {
            _car.Door.OpenDoors();
        }

        public void CloseDoors()
        {
            _car.Door.CloseDoors();
        }

        public DoorStatus GetDoorStatus()
        {
            return _car.Door.Status;
        }

        public int GetFloor()
        {
            return _currentFloor;
        }

        public async Task PushButton(int floor)
        {
            FloorButton buttonToPush = _car.FloorButtons.Where(button => button.FloorAssignedToButton == floor).First();
            if(buttonToPush != null)
            {
                buttonToPush.IsButtonIlluminated = true;
                await SetFloor(floor);
                buttonToPush.IsButtonIlluminated = false;
            }
        }

        private List<FloorButton> CreateFloorButtons()
        {
            var buttons = new List<FloorButton>();
            _floors.ForEach(floor =>
            {
                buttons.Add(new FloorButton(floor));
            });
            
            return buttons;
        }

        private Task<bool> SetFloor(int floor)
        {
            if (_floors.Contains(floor))
            {
                var maximumIterations = _floors.Count;
                while(_currentFloor != floor)
                {
                    // Move car between floors
                    Thread.Sleep(_timeToTraverseFloorsInMilliseconds);
                    // Set car to new floor
                    if(_currentFloor < floor)
                    {
                        _currentFloor++;   
                    }
                    else
                    {
                        _currentFloor--;
                    }

                    // Prevent infinite loops
                    maximumIterations--;
                    if(maximumIterations == 0)
                    {
                        throw new Exception($"Elevator attempted to set floor to {floor}, its current floor is {_currentFloor}, but it has moved through a total of {_floors.Count} floors.");
                    }
                }
                _currentFloor = floor;
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }
    }
}
