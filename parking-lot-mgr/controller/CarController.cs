using parking_lot_mgr.model.Request;
using parking_lot_mgr.model.Response;
using parking_lot_mgr.Service;
using parking_lot_mgr.Service.Impl;

namespace parking_lot_mgr.controller;

public class CarController
{
    //DI( DEPENDENCY INJECTIONS )
    private readonly ICarService _carService;
    
    //FIELD
    public CarResponse Create(CarRequest carRequest)
    {
        return _carService.Create(carRequest);
    } 
    public CarResponse GetById(string id)
    {
        return _carService.GetById(id);
    }

    public List<CarResponse> GetAll()
    {
        return _carService.GetAll();
    } 
    public CarResponse update(String id,CarRequest carRequest)
    {
        return _carService.Update(id,carRequest);
    } 
    public void delete(string id)
    {
        _carService.Delete(id);
    } 

    
}