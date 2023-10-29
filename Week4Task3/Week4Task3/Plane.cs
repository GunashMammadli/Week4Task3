using System.IO;
using System.Threading.Channels;

namespace Week4Task3
{
    internal class Plane : Vehicle
    {
        private float _wingLength;
        public float WingLength
        {
            get => _wingLength;
            set
            {
                if (value > 0)
                {
                    _wingLength = value;
                }
                else
                {
                    Console.WriteLine("Invalid Input!!!");
                }
            }
        }

        public Plane()
        {
            
        }

        public Plane(int DriveTime, int DrivePath, float WingLength) : base(DriveTime, DrivePath)
        {
            this.WingLength = WingLength;
        }

        public override float AvarageSpeed()
        {
            float speed = DrivePath / DriveTime;
            return speed;
        }

        public void GetFullInfo()
        {
            Console.WriteLine($"\nPlane Info \nDrive Time: {DriveTime} hour \nDrive Path: {DrivePath} km \nWing Length: {WingLength} " +
                              $"\nAvarage Speed: {AvarageSpeed()} km/h ");
        }
    }
}
