
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "098A3V93290", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "98737282", modelo: "Modelo 2", imei: "AC9EFD59FE", memoria: 512);
nokia.Ligar();
nokia.InstalarAplicativo("TELEGRAM");

