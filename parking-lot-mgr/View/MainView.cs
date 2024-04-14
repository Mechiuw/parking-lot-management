namespace parking_lot_mgr.View;

public class MainView
{
    public static void menu()
    {
        Console.WriteLine("#--=========================--#");
        Console.WriteLine("| PARKING LOT DATA MANAGEMENT |");
        Console.WriteLine("| 1. CAR SECTION              |");
        Console.WriteLine("| 2. MALL SECTION             |");
        Console.WriteLine("| 3. PARKING LOT SECTION      |");
        Console.WriteLine("#--=========================--#");
        string userIn = Console.ReadLine();
        
        switch (userIn)
        {
            case "1" :
                CarView.menu();
                break;
            case "2":
                MallView.menu();
                break;
            case "3":
                ParkingLotView.menu();
                break;
            default:
                Console.WriteLine("wrong input");
                MainView.menu();
                break;
        }
    }
}