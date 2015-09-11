using Microsoft.WindowsAzure.Mobile.Service;

namespace HappyOfficeService.DataObjects
{
    public class Point : EntityData
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public double Altitude { get; set; }
        public double Lux { get; set; }
        public double Desibel { get; set; }
        public string Username { get; set; }
    }
}