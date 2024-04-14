using parking_lot_mgr.model.Request;
using parking_lot_mgr.model.Response;

namespace parking_lot_mgr.Service;

public interface ICarService
{
    CarResponse Create(CarRequest carRequest);
    CarResponse GetById(string id);
    List<CarResponse> GetAll();
    CarResponse Update(string id,CarRequest carRequest);
    void Delete(string id);
}