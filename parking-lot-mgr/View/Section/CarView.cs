using parking_lot_mgr.constant;
using parking_lot_mgr.controller;
using parking_lot_mgr.model.Request;
using parking_lot_mgr.model.Response;
using parking_lot_mgr.Service;

namespace parking_lot_mgr.View;

public class CarView
{
    private readonly CarController _carController;
    public static void menu()
    {
        Console.WriteLine("#--=========================--#");
        Console.WriteLine("| CAR DATA MANAGEMENT         |");
        Console.WriteLine("| 1. ADD A CAR                |");
        Console.WriteLine("| 2. FIND BY PLATE NUM        |");
        Console.WriteLine("| 3. SHOW ALL CARS            |");
        Console.WriteLine("| 4. REPLACE / UPDATE A CAR   |");
        Console.WriteLine("| 5. DELETE A CAR             |");
        Console.WriteLine("#--=========================--#");
        string userIn = Console.ReadLine();
        
        switch (userIn)
        {
            case "1" :
                Console.WriteLine("insert platenumber, brand, type, color ");
                
                string plateNum = Console.ReadLine();
                string brand = Console.ReadLine();
                Types type = Enum.Parse<Types>(Console.ReadLine());
                string color = Console.ReadLine();
                
                CarRequest carRequest = new CarRequest(plateNum,brand,type,color);
                CarController carController = new CarController();
                carController.Create(carRequest);
                break;
            case "2":
                MallView.menu();
                break;
            case "3":
                ParkingLotView.menu();
                break;
            case "4":
                MallView.menu();
                break;
            case "5":
                ParkingLotView.menu();
                break;
            default:
                Console.WriteLine("wrong input");
                MainView.menu();
                break;
        }
    }
}