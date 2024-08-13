using FundamentalsChallenge.Models;

decimal initialPrice = 0;
decimal additionalPrice = 0;

Console.WriteLine("Welcome to the parking lot program!");

Console.WriteLine("Type the initial price: ");
initialPrice = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Type the additional price: ");
additionalPrice = Convert.ToDecimal(Console.ReadLine());

ParkingLot parkingLot = new ParkingLot(initialPrice, additionalPrice);

bool menuEnabled = true;
List<string> licensePlates = new List<string>();

while (menuEnabled)
{
  Console.Clear();
  Console.WriteLine("Type the option: ");
  Console.WriteLine("1 - Register a vehicle");
  Console.WriteLine("2 - Remove a vehicle");
  Console.WriteLine("3 - List vehicles");
  Console.WriteLine("4 - Exit");

  int option = int.Parse(Console.ReadLine());
  switch (option)
  {
    case 1:
      parkingLot.RegisterVehicle();
      break;
    case 2:
      parkingLot.RemoveVehicle();
      break;
    case 3:
      parkingLot.ListVehicles();
      break;
    case 4:
      menuEnabled = false;
      break;
    default:
      Console.WriteLine("Invalid option");
      break;
  }
  Console.WriteLine("Type any key to continue...");
  Console.ReadKey();
}
Console.WriteLine("Thank you for using the program!");