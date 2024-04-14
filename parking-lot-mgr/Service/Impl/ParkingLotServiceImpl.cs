using parking_lot_mgr.model.Entity;
using parking_lot_mgr.model.Request;
using parking_lot_mgr.model.Response;
using parking_lot_mgr.Repository;

namespace parking_lot_mgr.Service.Impl;

public class ParkingLotServiceImpl : IParkingLotService
{
    // DI ( DEPENDENCY INJECTIONS )
    private readonly ParkingLotRepository _parkingLotRepository;
    
    // CONSTRUCTOR
    public ParkingLotServiceImpl(ParkingLotRepository parkingLotRepository)
    {
        _parkingLotRepository = parkingLotRepository;
    }

    // FIELD
    public ParkingLotResponse<Car> Create(ParkingLotRequest<Car> parkingLot)
    {
        return _parkingLotRepository.AddPL(parkingLot);
    }

    public ParkingLotResponse<Car> GetById(string id)
    {
        return _parkingLotRepository.FindPL(id);
    }

    public List<ParkingLotResponse<Car>> GetAll()
    {
        return _parkingLotRepository.FindAllPL();
    }

    public ParkingLotResponse<Car> Update(string id, ParkingLotRequest<Car> parkingLotRequest)
    {
        return _parkingLotRepository.UpdatePL(id, parkingLotRequest);
    }

    public void Delete(string id)
    {
        _parkingLotRepository.RemovePL(id);
    }
}