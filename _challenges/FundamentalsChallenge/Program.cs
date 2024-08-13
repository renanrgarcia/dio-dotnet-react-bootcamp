Console.WriteLine("Welcome to the parking lot program!");

Console.WriteLine("Type the initial price: ");
int initialPrice = int.Parse(Console.ReadLine());
Console.WriteLine("Type the additional price: ");
int additionalPrice = int.Parse(Console.ReadLine());

bool exit = false;
while (!exit)
{
  // Console.Clear();
  Console.WriteLine("Type the option: ");
  Console.WriteLine("1 - Register a vehicle");
  Console.WriteLine("2 - Remove a vehicle");
  Console.WriteLine("3 - List vehicles");
  Console.WriteLine("4 - Exit");

  List<string> licensePlates = new List<string>();
  int option = int.Parse(Console.ReadLine());
  switch (option)
  {
    case 1:
      Console.WriteLine("Type the license plate to register: ");
      string licensePlateToRegister = Console.ReadLine();
      licensePlates.Add(licensePlateToRegister);
      Console.WriteLine("Type any key to continue...");
      Console.ReadKey();
      break;
    case 2:
      Console.WriteLine("Type the license plate to remove: ");
      string licensePlateToRemove = Console.ReadLine();
      licensePlates.Remove(licensePlateToRemove);
      Console.WriteLine("Type the amount of parked hours: ");
      int parkedHours = int.Parse(Console.ReadLine());
      Console.WriteLine($"The vehicle {licensePlateToRemove} was removed and you have to pay {initialPrice + additionalPrice * parkedHours}");
      Console.WriteLine("Type any key to continue...");
      Console.ReadKey();
      break;
    case 3:
      Console.WriteLine("Cars parked: ");
      foreach (string car in licensePlates)
      {
        Console.WriteLine(car);
      }
      Console.WriteLine("Type any key to continue...");
      Console.ReadKey();
      break;
    case 4:
      exit = true;
      break;
    default:
      Console.WriteLine("Invalid option");
      Console.WriteLine("Type any key to continue...");
      Console.ReadKey();
      break;
  }
}