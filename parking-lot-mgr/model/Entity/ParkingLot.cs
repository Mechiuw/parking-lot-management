namespace parking_lot_mgr.model.Entity;
using System.Collections.Generic;

public class ParkingLot<T>
{
    public string Id { get; set; }
    public List<T> Space { get; set; }

    public ParkingLot(string id, List<T> space)
    {
        Id = id;
        Space = space;
    }
}