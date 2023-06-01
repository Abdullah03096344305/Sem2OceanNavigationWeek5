using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanNavigationWeek5.BL
{
    class Angle
    {
        int degrees;
        float minutes;
        char directionLetter;
       public Angle(int degrees, float minutes, char directionLetter)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.directionLetter = directionLetter; 
        }
        public void ChangeAngle(int degrees, float minutes, char directionLetter)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.directionLetter = directionLetter;
        }
        public string GetAngleString()
        {
            return degrees + "°" + Math.Round(minutes, 1) + "' " + directionLetter;
        }
    }
    class Ship
    {
        public string serialNumber;
        public Angle latitude;
        public Angle longitude;

        public Ship(string serialNumber, Angle latitude, Angle longitude)
        {
            this.serialNumber = serialNumber;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public void PrintPosition()
        {
            Console.WriteLine("Ship is at " + latitude.GetAngleString() + " and " + longitude.GetAngleString());
        }

        public void PrintSerialNumber()
        {
            Console.WriteLine("Ship's serial number is " + serialNumber);
        }
    }
}
