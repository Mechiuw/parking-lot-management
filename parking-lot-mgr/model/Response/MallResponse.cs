using parking_lot_mgr.model.Entity;

namespace parking_lot_mgr.model.Response;

public class MallResponse
{
    public string Name { get; set; }
    public string Address { get; set; }
    public ParkingLot<Car> ParkingLot { get; set; }

    public MallResponse(string name, string address, ParkingLot<Car> parkingLot)
    {
        Name = name;
        Address = address;
        ParkingLot = parkingLot;
    }
}