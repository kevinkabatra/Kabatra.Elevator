namespace Kabatra.Elevator.HoistMechanism
{
    public class HoistMechanism
    {
        public readonly int MechanismSpeedInMetersPerSecond;
        public readonly HoistMechanismType HoistMechanismType;

        public HoistMechanism(HoistMechanismType hoistMechanismType) 
        {
            HoistMechanismType = hoistMechanismType;

            switch(HoistMechanismType)
            {
                case HoistMechanismType.Traction:
                    MechanismSpeedInMetersPerSecond = 3;
                    break;
                case HoistMechanismType.Hydraulic:
                    MechanismSpeedInMetersPerSecond = 1;
                    break;
                default: 
                    throw new ArgumentException($"Mechanism Type: {HoistMechanismType} has not been implemented.");
            }
        }
    }
}
