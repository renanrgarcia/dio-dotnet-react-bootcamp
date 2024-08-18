using CellphoneSystemChallenge.Models;

Smartphone nokia = new Nokia(number: "123456789", model: "Nokia 3310", imei: "123456789", memory: 64);
nokia.Call();
nokia.ReceiveCall();
nokia.InstallApp("Whatsapp");

System.Console.WriteLine("\n");
Smartphone iphone = new Iphone(number: "123456789", model: "Iphone 13", imei: "123456789", memory: 64);
iphone.Call();
iphone.ReceiveCall();
iphone.InstallApp("Facebook");