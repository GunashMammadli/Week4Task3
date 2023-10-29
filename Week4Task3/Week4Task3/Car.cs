namespace Week4Task3
{
    internal class Car : Vehicle, ITransmission, IWheel, IEngine
    {
        private byte _doorCount;
        private string _winCode;
        private string _transmissionKind;
        private int _wheelThickness;
        private int _horsePower;
        private int _tankSize;
        private int _currentOil;
        private string _fuelType;
        public byte DoorCount
        {
            get => _doorCount;
            set
            {
                if (value > 0 && value < 7)
                {
                    _doorCount = value;
                }
                else
                {
                    Console.WriteLine("Invalid Input!!");
                }
            }
        }
        public string WinCode
        {
            get => _winCode;
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && value.Length == 17 && ContainCapitalLetters(WinCode) && ContainDigit(WinCode))
                {
                    _winCode = value;
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

        public string TransmissionKind
        {
            get => _transmissionKind;
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && (value == "manual" || value == "automatic"))
                {
                    _transmissionKind = value;
                }
                else
                {
                    Console.WriteLine("Invalid Input!!!");
                }
            }
        }

        public int HorsePower
        {
            get => _horsePower;
            set
            {
                if (value > 0)
                {
                    _horsePower = value;
                }
                else
                {
                    Console.WriteLine("Invalid Input!!!");
                }
            }
        }
        public int TankSize
        {
            get => _tankSize;
            set
            {
                if (value > 0)
                {
                    _tankSize = value;
                }
                else
                {
                    Console.WriteLine("Invalid Input!!!");
                }
            }
        }
        public int CurrentOil
        {
            get => _currentOil;
            set
            {
                if (value > 0 && TankSize >= value)
                {
                    _currentOil = value;
                }
                else
                {
                    Console.WriteLine("Invalid Input!!!");
                }
            }
        }
        public string FuelType
        {
            get => _fuelType;
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && (value == "benzin" || value == "diesel"))
                {
                    _fuelType = value;
                }
                else
                {
                    Console.WriteLine("Invalid Input!!!");
                }
            }
        }

        public bool ContainDigit(string WinCode)
        {
            for (int i = 0; i < WinCode.Length; i++)
            {
                if (WinCode[i] >= 48 && WinCode[i] <= 57)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ContainCapitalLetters(string WinCode)
        {
            for (int i = 0; i < WinCode.Length; i++)
            {
                if (WinCode[i] >= 65 && WinCode[i] <= 90)
                {
                    return true;
                }
            }
            return false;
        }

        public float RemainOilAmount()
        {
            float remainOilAmount = TankSize - CurrentOil;
            return remainOilAmount;
        }

        public Car()
        {
            
        }

        public Car(int DriveTime, int DrivePath, byte DoorCount, string WinCode, string TransmissionKind, int WheelThickness, 
                   int HorsePower, int TankSize, int CurrentOil, string FuelType ) : base(DriveTime, DrivePath)
        {                                                                        
            this.DoorCount = DoorCount;                                        
            this.WinCode = WinCode;  
            this.TransmissionKind = TransmissionKind;
            this.WheelThickness = WheelThickness;
            this.CurrentOil = CurrentOil;
            this.FuelType = FuelType;
            this.HorsePower = HorsePower;
            this.TankSize = TankSize;
        }

        public override float AvarageSpeed()
        {
            float speed = DrivePath / DriveTime;
            return speed;
        }

        public void GetFullInfo()
        {
            Console.WriteLine($"\nCar Info \nDrive Time: {DriveTime} hour \nDrive Path: {DrivePath} km \nDoor Count: {DoorCount} " +
                              $"\nWin Code: {WinCode} \nTransmission Kind: {TransmissionKind} \nWheel Thickness: {WheelThickness}" +
                              $"\nHorse Power: {HorsePower} \nTank Size: {TankSize} \nCurrent Oil: {CurrentOil} \nFuel Type: {FuelType}" +
                              $"\nAvarage Speed: {AvarageSpeed()} km/h ");
        }
    }                                                                 
}
