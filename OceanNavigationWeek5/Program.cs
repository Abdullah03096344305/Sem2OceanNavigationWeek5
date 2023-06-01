using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OceanNavigationWeek5.BL;
using System.Threading.Tasks;

namespace OceanNavigationWeek5
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Ship[] ships = new Ship[10]; 
            int shipCount = 0;

            while (true)
            {
                Console.WriteLine("Abdullah's Ships Menu:");
                Console.WriteLine("1. Add Ship");
                Console.WriteLine("2. View Ship Position");
                Console.WriteLine("3. View Ship Serial Number");
                Console.WriteLine("4. Change Ship Position");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter Ship Number: ");
                    string shipNumber = Console.ReadLine();

                    Console.WriteLine("Enter Ship Latitude:");
                    Console.Write("Enter Latitude's Degree: ");
                    int latitudeDegrees = int.Parse(Console.ReadLine());
                    Console.Write("Enter Latitude's Minute: ");
                    float latitudeMinutes = float.Parse(Console.ReadLine());
                    Console.Write("Enter Latitude's Direction: ");
                    char latitudeDirection = Console.ReadLine()[0];

                    Console.WriteLine("Enter Ship Longitude:");
                    Console.Write("Enter Longitude's Degree: ");
                    int longitudeDegrees = int.Parse(Console.ReadLine());
                    Console.Write("Enter Longitude's Minute: ");
                    float longitudeMinutes = float.Parse(Console.ReadLine());
                    Console.Write("Enter Longitude's Direction: ");
                    char longitudeDirection = Console.ReadLine()[0];

                    Angle latitude = new Angle(latitudeDegrees, latitudeMinutes, latitudeDirection);
                    Angle longitude = new Angle(longitudeDegrees, longitudeMinutes, longitudeDirection);

                    ships[shipCount] = new Ship(shipNumber, latitude, longitude);
                    shipCount++;
                }
                else if (choice == 2)
                {
                    Console.Write("Enter Ship Serial Number to find its position: ");
                    string serialNumber = Console.ReadLine();

                    Ship ship = Array.Find(ships, s => s != null && s.serialNumber == serialNumber);
                    if (ship != null)
                    {
                        ship.PrintPosition();
                    }
                    else
                    {
                        Console.WriteLine("Ship not found.");
                    }
                }
                else if (choice == 3)
                {
                    Console.Write("Enter the ship latitude: ");
                    string latitudeString = Console.ReadLine();
                    Console.Write("Enter the ship longitude: ");
                    string longitudeString = Console.ReadLine();

                    Ship ship = Array.Find(ships, s => s != null && s.latitude.GetAngleString() == latitudeString && s.longitude.GetAngleString() == longitudeString);
                    if (ship != null)
                    {
                        ship.PrintSerialNumber();
                    }
                    else
                    {
                        Console.WriteLine("Ship not found.");
                    }
                }
                else if (choice == 4)
                {
                    Console.Write("Enter Ship's serial number whose position you want to change: ");
                    string serialNumber = Console.ReadLine();

                    Ship ship = Array.Find(ships, s => s != null && s.serialNumber == serialNumber);
                    if (ship != null)
                    {
                        Console.WriteLine("Enter Ship Latitude:");
                        Console.Write("Enter Latitude's Degree: ");
                        int latitudeDegrees = int.Parse(Console.ReadLine());
                        Console.Write("Enter Latitude's Minute: ");
                        float latitudeMinutes = float.Parse(Console.ReadLine());
                        Console.Write("Enter Latitude's Direction: ");
                        char latitudeDirection = Console.ReadLine()[0];

                        Console.WriteLine("Enter Ship Longitude:");
                        Console.Write("Enter Longitude's Degree: ");
                        int longitudeDegrees = int.Parse(Console.ReadLine());
                        Console.Write("Enter Longitude's Minute: ");
                        float longitudeMinutes = float.Parse(Console.ReadLine());
                        Console.Write("Enter Longitude's Direction: ");
                        char longitudeDirection = Console.ReadLine()[0];

                        ship.latitude.ChangeAngle(latitudeDegrees, latitudeMinutes, latitudeDirection);
                        ship.longitude.ChangeAngle(longitudeDegrees, longitudeMinutes, longitudeDirection);
                        Console.WriteLine("Ship position changed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Ship not found.");
                    }
                }
                else if (choice == 5)
                {
                    break;
                }
            }

        }
    }
}
