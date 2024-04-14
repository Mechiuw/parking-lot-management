using parking_lot_mgr.constant;

namespace parking_lot_mgr.model.Response;

public class CarResponse
{
    public string PlateNumber { get; set; }
    public string Brand { get; set; }
    public Types Type { get; set; }

    public CarResponse(string plateNumber, string brand, Types type)
    {
        PlateNumber = plateNumber;
        Brand = brand;
        Type = type;
    }
}