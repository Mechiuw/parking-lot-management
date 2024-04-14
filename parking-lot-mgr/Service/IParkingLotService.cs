using parking_lot_mgr.model.Entity;
using parking_lot_mgr.model.Request;
using parking_lot_mgr.model.Response;

namespace parking_lot_mgr.Service;

public interface IParkingLotService
{
    ParkingLotResponse<Car> Create(ParkingLotRequest<Car> parkingLot);
    ParkingLotResponse<Car> GetById(string id);
    List<ParkingLotResponse<Car>> GetAll();
    ParkingLotResponse<Car> Update(string id,ParkingLotRequest<Car> parkingLotRequest);
    void Delete(string id);
}