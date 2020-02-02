using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingApp.Models
{
    public class Airport
    {
        public int Capacity { get; set; }
        public int Occupancy { get; set; }
        public int FreeSpots
        {
            get
            { return Capacity - Occupancy; }

        }

        private List<Airplane> parkedVehicles = new List<Airplane>();

        public Airport(int capacity)
        {
            Capacity = capacity;
            Occupancy = 0;
        }

        public void ParkTheAirplane(Airplane airplane)
        {
            if (FreeSpots > 0)
            {
                parkedVehicles.Add(airplane);
                Occupancy += 1;
                Console.WriteLine($"{airplane.AirplaneModel} {airplane.AirplaneType} has parked at airport. Currently there is {FreeSpots} free places at parking.");
            }

        }

        public void LeaveAirport(Airplane airplane)
        {
            
            parkedVehicles.Remove(airplane);
            Occupancy -= 1;
            airplane.Parking = null;
            Console.WriteLine($"{airplane.AirplaneModel} {airplane.AirplaneType} has parked at airport. Currently there is {FreeSpots} free places at airport.");

        }


    }
}
