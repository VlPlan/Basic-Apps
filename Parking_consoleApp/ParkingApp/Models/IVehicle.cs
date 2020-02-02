using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingApp.Models
{
    public interface IVehicle<T> where T:IVehicle<T>
    {
        Parking<T> Parking { get; set; }
    }
}
