namespace ParkingApp.Models
{
    public enum BoatType
    {
        Raft,
        Sailboat,
        Motorboat
    }

    public class Boat:IVehicle<Boat>
    {
        public string BoatName { get; set; }
        public BoatType BoatType { get; set; }
        public Parking<Boat> Parking { get; set; }
    }
}