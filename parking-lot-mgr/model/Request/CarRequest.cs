using parking_lot_mgr.constant;

namespace parking_lot_mgr.model.Request;

public class CarRequest
{
    public string PlateNumber { get; set; }
    public string Brand { get; set; }
    public Types Type { get; set; }
    public string Color { get; set; }

    public CarRequest(string plateNumber, string brand, Types type, string color)
    {
        PlateNumber = plateNumber;
        Brand = brand;
        Type = type;
        Color = color;
    }
}