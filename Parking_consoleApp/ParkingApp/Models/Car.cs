using System;
using System.Collections.Generic;
using System.Text;


namespace ParkingApp.Models
{
    public enum CarModel
    {
        Audi, 
        BMW,
        Fiat,
        Mercedes,
        Skoda,
        Chevrolet,
        Mazda,
        Seat,
        Porsche,
        Citroen,
        Peugeut
    }

    public enum FuelType
    {
        Petrol,
        Diesel,
        Electric,
        Hybrid,
        LPG

    }
    public class Car : IVehicle<Car>
    {
        public string Model { get; set; }
        public CarModel Make { get; set; }
        public  FuelType Fuel { get; set; }
        public Parking<Car> Parking { get; set; }
        public bool isItParked
        {
            get
            {
                return Parking != null;
            }
        }
      
        public void LeaveParking()
        {
            Parking.LeaveParking(this);
        }
    }
}
