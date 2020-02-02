using System;
using System.Collections.Generic;
using System.Text;
using ParkingApp.Models;

namespace ParkingApp.Models
{
    public class Parking<T> where T:IVehicle<T>
    {
        public int Capacity { get; private set; }
        public int Occupancy { get; private set; }
        public int FreeSpots
        {
            get
            { return Capacity - Occupancy; }

        }

        private List<T> parkedVehicles = new List<T>();

        public Parking(int capacity)
        {
            Capacity = capacity;
            Occupancy = 0;

        }

        public void ParkTheVehicle(T vehicle)
        {
            if (FreeSpots > 0)
            {
                parkedVehicles.Add(vehicle);
                Occupancy += 1;
                vehicle.Parking = this;

            }

            Console.WriteLine($"{vehicle} has parked. Currently there is {FreeSpots} free places at parking {vehicle.Parking}");

        }

        public void LeaveParking(T vehicle)
        {
            parkedVehicles.Remove(vehicle);
            Occupancy -= 1;
            vehicle.Parking = null;
            Console.WriteLine($"{vehicle} has left the parking. Currently there is {FreeSpots} free places at parking {vehicle.Parking}");
        }
    }
}
