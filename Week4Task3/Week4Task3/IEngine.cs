using System.IO;

namespace Week4Task3
{
    internal interface IEngine
    {
        public int HorsePower { get; set; }
        
        public int TankSize { get; set; }
        
        public int CurrentOil { get; set; }
        
        public string FuelType { get; set; }
        
        public float RemainOilAmount();
    }
}
