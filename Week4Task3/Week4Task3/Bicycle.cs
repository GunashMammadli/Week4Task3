namespace Week4Task3
{
    internal class Bicycle : Vehicle, IWheel
    {
        private string _pedalKind;
        private int _wheelThickness;
        public string PedalKind
        {
            get => _pedalKind;
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && (value == "clipless" || value == "flats" || value == "hybrid"))
                {
                    _pedalKind = value;
                }
                else
                {
                    Console.WriteLine("Invalid Input!!");
                }
            }
        }

        public int WheelThickness
        {
            get => _wheelThickness;
            set
            {
                if (value > 0)
                {
                    _wheelThickness = value;
                }
                else
                {
                    Console.WriteLine("Invalid Input!!!");
                }
            }
        }
        public Bicycle()
        {
            
        }

        public Bicycle(int DriveTime, int DrivePath, string PedalKind, int WheelThickness) : base(DriveTime, DrivePath)
        {
            this.PedalKind = PedalKind;
            this.WheelThickness = WheelThickness;
        }

        public override float AvarageSpeed()
        {
            float speed = DrivePath / DriveTime;
            return speed;
        }

        public void GetFullInfo()
        {
            Console.WriteLine($"\nBicycle Info \nDrive Time: {DriveTime} hour \nDrive Path: {DrivePath} km \nPedal Kind: {PedalKind} " +
                              $"\nWheel Thickness: {WheelThickness} \nAvarage Speed: {AvarageSpeed()} km/h ");
        }
    }
}
