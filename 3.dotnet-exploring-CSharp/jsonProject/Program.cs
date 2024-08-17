using jsonProject.Models;
using Newtonsoft.Json;

List<Sale> sales = new List<Sale>();

Sale s1 = new Sale(1, "Notebook", 2500.00m, DateTime.Now);
Sale s2 = new Sale(2, "Tablet", 1500.00m, DateTime.Now);
Sale s3 = new Sale(3, "Smartphone", 800.00m, DateTime.Now);

sales.Add(s1);
sales.Add(s2);
sales.Add(s3);

// JSON serialization
string serializedJson = JsonConvert.SerializeObject(sales, Formatting.Indented);

File.WriteAllText("Files/sales.json", serializedJson);

Console.WriteLine(serializedJson);