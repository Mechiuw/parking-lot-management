using parking_lot_mgr.model.Entity;
using parking_lot_mgr.model.Request;
using parking_lot_mgr.model.Response;
using parking_lot_mgr.Service;

namespace parking_lot_mgr.controller;

public class ParkingLotController
{
    // DI ( DEPENDENCY INJECTIONS ) 
    private readonly IParkingLotService _parkingLotService;
    
    // CONSTRUCTOR
    public ParkingLotController(IParkingLotService parkingLotService)
    {
        _parkingLotService = parkingLotService;
    }
    
    // FIELD
    public ParkingLotResponse<Car> Create(ParkingLotRequest<Car> parkingLotRequest)
    {
        return _parkingLotService.Create(parkingLotRequest);
    }

    public ParkingLotResponse<Car> GetById(string id)
    {
        return _parkingLotService.GetById(id);
    }

    public List<ParkingLotResponse<Car>> GetAll()
    {
        return _parkingLotService.GetAll();
    }

    public ParkingLotResponse<Car> Update(string id,ParkingLotRequest<Car> parkingLotRequest)
    {
        return _parkingLotService.Update(id, parkingLotRequest);
    }

    public void Delete(string id)
    {
        _parkingLotService.Delete(id);
    }
}