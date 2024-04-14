using parking_lot_mgr.model.Entity;
using parking_lot_mgr.model.Request;
using parking_lot_mgr.model.Response;

namespace parking_lot_mgr.Repository;

public class MallRepository
{
    //PROPERTY
    private List<Mall> ListOfMalls {get; set;}

    //CONSTRUCTOR
    public MallRepository(List<Mall> listOfMalls)
    {
        ListOfMalls = listOfMalls;
    }
    
    //FIELD
    public MallResponse AddMall(MallRequest mallRequest)
    {
        Mall mall = new Mall(mallRequest.Name, mallRequest.Address, mallRequest.Type, mallRequest.ParkingLot);
        ListOfMalls.Add(mall);
        MallResponse response = new MallResponse(mall.Name, mall.Address, mall.ParkingLot);
        return response;
    }

    public MallResponse FindMall(string id)
    {
        foreach (var a in ListOfMalls)
        {
            if (a.Name == id)
            {
                Mall mall = new Mall(a.Name, a.Address, a.Type, a.ParkingLot);
                MallResponse response = new MallResponse(mall.Name, mall.Address, mall.ParkingLot);
                return response;
            }
        }

        return new MallResponse("not found", "not found", null);;
    }

    public List<MallResponse> FindAllMall()
    {
        List<MallResponse> malls = new List<MallResponse>();
        foreach (var a in ListOfMalls)
        {
            MallResponse response = new MallResponse(a.Name, a.Address, a.ParkingLot);
            malls.Add(response);
        }

        return malls;
    }

    public MallResponse UpdateMall(string id,MallRequest mallRequest)
    {
        int index = ListOfMalls.FindIndex(car => car.Name == id);
        if (index != -1)
        {
            Mall mall = new Mall(mallRequest.Name, mallRequest.Address, mallRequest.Type, mallRequest.ParkingLot);
            ListOfMalls[index] = mall;
            MallResponse mallResponse = new MallResponse(mall.Name, mall.Address, mall.ParkingLot);
            return mallResponse;
        }
        else
        {
            return new MallResponse("not found", "not found", null);
        }
    }

    public void DeleteMall(string id)
    {
        ListOfMalls.RemoveAll(mall => mall.Name == id);
    }
}