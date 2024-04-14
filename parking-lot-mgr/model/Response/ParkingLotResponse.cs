namespace parking_lot_mgr.model.Response;

public class ParkingLotResponse<T>
{
    public string Id { get; set; }
    public List<T> Space { get; set; }

    public ParkingLotResponse(string id, List<T> space)
    {
        Id = id;
        Space = space;
    }
}