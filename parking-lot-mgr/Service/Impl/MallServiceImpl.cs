using parking_lot_mgr.model.Request;
using parking_lot_mgr.model.Response;
using parking_lot_mgr.Repository;

namespace parking_lot_mgr.Service.Impl;

public class MallServiceImpl : IMallService
{
    private readonly MallRepository _mallRepository;

    public MallServiceImpl(MallRepository mallRepository)
    {
        _mallRepository = mallRepository;
    }

    public MallResponse Create(MallRequest mallRequest)
    {
        return _mallRepository.AddMall(mallRequest);
    }

    public MallResponse GetById(string id)
    {
        return _mallRepository.FindMall(id);
    }

    public List<MallResponse> GetAll()
    {
        return _mallRepository.FindAllMall();
    }

    public MallResponse Update(string id, MallRequest mallRequest)
    {
        return _mallRepository.UpdateMall(id, mallRequest);
    }

    public void Delete(string id)
    {
        _mallRepository.DeleteMall(id);
    }
}