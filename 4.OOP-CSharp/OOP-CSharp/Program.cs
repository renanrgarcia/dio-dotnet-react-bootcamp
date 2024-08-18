using OOP_CSharp.Interfaces;
using OOP_CSharp.Models;

// CurrentAccount currentAccount = new CurrentAccount(123456);

// currentAccount.Deposit(100);
// currentAccount.GetBalance();

// Computer computer = new Computer();

// System.Console.WriteLine(computer.ToString());

ICalculator calculator = new CommonCalculator();

System.Console.WriteLine(calculator.Sum(10, 20));
System.Console.WriteLine(calculator.Multiply(10, 20));
System.Console.WriteLine(calculator.Divide(10, 20));
System.Console.WriteLine(calculator.Subtract(10, 20));