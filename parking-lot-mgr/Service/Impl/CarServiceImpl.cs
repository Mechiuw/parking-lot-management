using parking_lot_mgr.model.Request;
using parking_lot_mgr.model.Response;
using parking_lot_mgr.Repository;

namespace parking_lot_mgr.Service.Impl;

public class CarServiceImpl : ICarService
{
    //DI ( DEPENDENCY INJECTIONS )
    private readonly CarRepository _carRepository;

    //CONSTRUCTOR
    public CarServiceImpl(CarRepository carRepository)
    {
        _carRepository = carRepository;
    }
    
    //FIELD
    public CarResponse Create(CarRequest carRequest) 
    {
        return _carRepository.AddCar(carRequest);
    }

    public CarResponse GetById(string id)
    {
        return _carRepository.FindCar(id);
    }

    public List<CarResponse> GetAll()
    {
        return _carRepository.FindAllCar();
    }

    public CarResponse Update(string id, CarRequest carRequest)
    {
        return _carRepository.ReplaceCar(id, carRequest);
    }

    public void Delete(string id)
    {
        _carRepository.RemoveCar(id);
    }
}