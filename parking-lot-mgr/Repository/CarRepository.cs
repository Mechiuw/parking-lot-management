using parking_lot_mgr.constant;
using parking_lot_mgr.model.Entity;
using parking_lot_mgr.model.Request;
using parking_lot_mgr.model.Response;

namespace parking_lot_mgr.Repository;

public class CarRepository
{
    //PROPERTY
    private List<Car> ListOfCars {get;set;}
    
    //CONSTRUCTOR
    public CarRepository(List<Car> listOfCars)
    {
        this.ListOfCars = listOfCars;
    }
    
    //FIELD
    public CarResponse AddCar(CarRequest carRequest)
    {
        Car car = new Car(carRequest.PlateNumber, carRequest.Brand, carRequest.Type, carRequest.Color);
        ListOfCars.Add(car);
        CarResponse response = new CarResponse(car.PlateNumber, car.Brand, car.Type);
        return response;
    }
    public CarResponse FindCar(string id)
    {
        foreach (var a in ListOfCars)
        {
            if (a.PlateNumber == id)
            {
                Car car = new Car(a.PlateNumber,a.Brand,a.Type,a.Color);
                CarResponse response = new CarResponse(car.PlateNumber,car.Brand,car.Type);
                return response;
            }
        }
        return null;
    }


    public List<CarResponse> FindAllCar()
    {
        List<CarResponse> allCarResponses = new List<CarResponse>();

        foreach (var all in ListOfCars)
        {
            CarResponse car = new CarResponse(all.PlateNumber, all.Brand, all.Type);
            allCarResponses.Add(car);
        }

        return allCarResponses;
    }

    public CarResponse ReplaceCar(string id, CarRequest carRequest)
    {
        int index = this.ListOfCars.FindIndex(car => car.PlateNumber == id);
        if (index != -1)
        {
            Car car = new Car(carRequest.PlateNumber,carRequest.Brand,carRequest.Type,carRequest.Color);
            this.ListOfCars[index] = car;
            CarResponse response = new CarResponse(car.PlateNumber,car.Brand,car.Type);
            return response;
        }
        else
        {
            return new CarResponse("notfound-xxx", "not found",Types.Invalid);
        }   
    }

    public void RemoveCar(string id)
    {
        ListOfCars.RemoveAll(car => car.PlateNumber == id);
    }
}