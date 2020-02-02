using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingApp.Models
{
    public class Garage
    {
        public int Capacity { get; set; }
        public int Occupancy { get; set; }
        public int FreeSpots
        {
            get
            { return Capacity - Occupancy; }
           
        }

        private List<Car> parkedVehicles = new List<Car>();

        public Garage(int capacity)
        {
            Capacity = capacity;
            Occupancy = 0;
            
        }

        public void ParkTheVehicle(Car vehicle)
        {
            if (FreeSpots > 0)
            {
                parkedVehicles.Add(vehicle);
                Occupancy+= 1;
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} with {vehicle.Fuel} has parked. Currently there is {FreeSpots} free places at parking.");
            }
            
        }

        public void LeaveParking(Car vehicle)
        {
            Console.WriteLine($"{vehicle.Make} {vehicle.Model} with {vehicle.Fuel} has left the parking. Currently there is {FreeSpots} free places at parking.");
            parkedVehicles.Remove(vehicle);
            Occupancy -= 1;
            vehicle.Parking = null;
           
        }




    }

}
