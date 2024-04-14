using parking_lot_mgr.model.Request;
using parking_lot_mgr.model.Response;
using parking_lot_mgr.Service;

namespace parking_lot_mgr.controller;

public class MallController
{
    //DI( DEPENDENCY INJECTIONS )
    private readonly IMallService _mallService;
    
    //CONSTRUCTOR
    public MallController(IMallService mallService)
    {
        _mallService = mallService;
    }
    
    //FIELD
    public MallResponse Create(MallRequest mallRequest)
    {
        return _mallService.Create(mallRequest);
    } 
    
    public MallResponse GetById(string id)
    {
        return _mallService.GetById(id);
    }

    public List<MallResponse> GetAll()
    {
        return _mallService.GetAll();
    }
    
    public MallResponse Update(String id,MallRequest mallRequest)
    {
        return _mallService.Update(id,mallRequest);
    }
    
    public void Delete(string id)
    {
        _mallService.Delete(id);
    } 
}