namespace parking_lot_mgr.model.Entity;

public class Mall
{
    public string Name { get; set; }
    public string Address { get; set; }
    public Type Type { get; set; }
    public ParkingLot<Car> ParkingLot { get; set; }

    public Mall(string name, string address, Type type, ParkingLot<Car> parkingLot)
    {
        Name = name;
        Address = address;
        Type = type;
        ParkingLot = parkingLot;
    }
    
    
}