using parking_lot_mgr.model.Request;
using parking_lot_mgr.model.Response;

namespace parking_lot_mgr.Service;

public interface IMallService
{
    MallResponse Create(MallRequest mallRequest);
    MallResponse GetById(string id);
    List<MallResponse> GetAll();
    MallResponse Update(string id,MallRequest mallRequest);
    void Delete(string id);
}