using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "12345678", modelo: "Modelo 1", imei: "1111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Bet365");

System.Console.WriteLine();

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "87654321", modelo: "Modelo 3", imei: "3333333", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Cloud");