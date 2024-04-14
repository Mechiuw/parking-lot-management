using parking_lot_mgr.model.Entity;
using parking_lot_mgr.model.Request;
using parking_lot_mgr.model.Response;

namespace parking_lot_mgr.Repository;

public class ParkingLotRepository
{
    // DI ( DEPENDENCY INJECTION ) 
    private List<ParkingLot<Car>> ListOfParkingLot { get; set; }
    
    // CONSTRUCTOR
    public ParkingLotRepository(List<ParkingLot<Car>> listOfParkingLot)
    {
        ListOfParkingLot = listOfParkingLot;
    }
    
    //FIELD
    public ParkingLotResponse<Car> AddPL(ParkingLotRequest<Car> parkingLotRequest)
    {
        ParkingLot<Car> parkingLot = new ParkingLot<Car>(parkingLotRequest.Id, parkingLotRequest.Space);
        ListOfParkingLot.Add(parkingLot);
        ParkingLotResponse<Car> response = new ParkingLotResponse<Car>(parkingLot.Id, parkingLot.Space);
        return response;
    }
    public ParkingLotResponse<Car> FindPL(string id)
    {
        foreach (var a in ListOfParkingLot)
        {
            if (a.Id == id)
            {
                ParkingLot<Car> parkingLot = new ParkingLot<Car>(a.Id, a.Space);
                ParkingLotResponse<Car> response = new ParkingLotResponse<Car>(parkingLot.Id, parkingLot.Space);
                return response;
            }
        }

        return new ParkingLotResponse<Car>("not found", null);
    }
    
    public List<ParkingLotResponse<Car>> FindAllPL()
    {
        List<ParkingLotResponse<Car>> parkingLot = new List<ParkingLotResponse<Car>>();
        foreach (var a in ListOfParkingLot)
        {
            ParkingLotResponse<Car> response = new ParkingLotResponse<Car>(a.Id,a.Space);
            parkingLot.Add(response);
        }

        return parkingLot;
    }
    
    public ParkingLotResponse<Car> UpdatePL(string id,ParkingLotRequest<Car> parkingLotRequest)
    {
        int index = ListOfParkingLot.FindIndex(park => park.Id == id);
        if (index != -1)
        {
            ParkingLot<Car> parkingLot = new ParkingLot<Car>(parkingLotRequest.Id,parkingLotRequest.Space);
            ListOfParkingLot[index] = parkingLot;
            ParkingLotResponse<Car> parkingLotResponse = new ParkingLotResponse<Car>(parkingLotRequest.Id, parkingLotRequest.Space);
            return parkingLotResponse;
        }
        else
        {
            return new ParkingLotResponse<Car>("not found", null);
        }
    }

    public void RemovePL(string id)
    {
        ListOfParkingLot.RemoveAll(pl => pl.Id == id);
    }
}