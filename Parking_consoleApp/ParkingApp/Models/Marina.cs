using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingApp.Models
{
   public class Marina:Parking<Boat>
    {
        public Marina(int capacity):base(capacity)
        {

        }

    }
}
