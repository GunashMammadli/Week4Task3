namespace Week4Task3
{
    internal abstract class Vehicle
    {
        private int _driveTime;
        private int _drivePath;
        public int DriveTime 
        { 
            get => _driveTime; 
            set 
            {
                if (value > 0)
                {
                    _driveTime = value;
                }
                else
                {
                    Console.WriteLine("Drive time cannot be negative");
                }
            } 
        }
        public int DrivePath
        {
            get => _drivePath;
            set
            {
                if (value > 0)
                {
                    _drivePath = value;
                }
                else
                {
                    Console.WriteLine("Drive path cannot be negative");
                }
            }
        }

        public abstract float AvarageSpeed();

        public Vehicle()
        {
            
        }

        public Vehicle(int DriveTime, int DrivePath)
        {
            this.DriveTime = DriveTime;
            this.DrivePath = DrivePath;
        }
    }
}
