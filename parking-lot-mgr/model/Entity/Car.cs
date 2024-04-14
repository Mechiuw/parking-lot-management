
using parking_lot_mgr.constant;

namespace parking_lot_mgr.model.Entity;

public class Car
{
    public string PlateNumber { get; set; }
    public string Brand { get; set; }
    public Types Type { get; set; }
    public string Color { get; set; }

    public Car(string plateNumber, string brand, Types type, string color)
    {
        PlateNumber = plateNumber;
        Brand = brand;
        Type = type;
        Color = color;
    }
}