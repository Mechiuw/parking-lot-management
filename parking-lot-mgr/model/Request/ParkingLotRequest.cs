namespace parking_lot_mgr.model.Request;

public class ParkingLotRequest<T>
{
    public string Id { get; set; }
    public List<T> Space { get; set; }

    public ParkingLotRequest(string id, List<T> space)
    {
        Id = id;
        Space = space;
    }
}