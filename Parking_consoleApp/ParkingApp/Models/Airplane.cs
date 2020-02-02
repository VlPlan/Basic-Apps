using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingApp.Models
{
    public enum AirplaneType
    {
        Civil,
        Combat
    }

    public class Airplane:IVehicle<Airplane>
    {
        public AirplaneType AirplaneType { get; set; }
        public string AirplaneModel { get; set; }
        public Parking<Airplane> Parking { get; set; }

    }
}
