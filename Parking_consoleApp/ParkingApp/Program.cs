using System;
using System.Collections.Generic;
using ParkingApp.Models;

namespace ParkingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage parking = new Garage(100);
            Car Audi = new Car { Make = CarModel.Audi, Model = "A4", Fuel = FuelType.Diesel };
            Car BMW = new Car { Make = CarModel.BMW, Model = "X1", Fuel = FuelType.Petrol };
            Car Skoda = new Car { Make = CarModel.Skoda, Model = "Fabia", Fuel = FuelType.LPG };


            Airport airport = new Airport(20);
            Airplane Boeing = new Airplane { AirplaneModel = "Boeing", AirplaneType = AirplaneType.Combat };
            Airplane WizzPlane = new Airplane { AirplaneModel = "WizzAirPlane", AirplaneType = AirplaneType.Civil };

            Marina marina = new Marina(10);
            Boat sailboat = new Boat { BoatName = "Whistle", BoatType = BoatType.Sailboat };
            

            parking.ParkTheVehicle(Audi);
            parking.ParkTheVehicle(BMW);
            parking.ParkTheVehicle(Skoda);

            airport.ParkTheAirplane(Boeing);
            airport.ParkTheAirplane(WizzPlane);

            marina.ParkTheVehicle(sailboat);

            parking.LeaveParking(Audi);
            airport.LeaveAirport(WizzPlane);







        }
    }
}
