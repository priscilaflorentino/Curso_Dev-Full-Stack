using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "99999-1000", modelo: "Nokia 1.0", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");
Console.WriteLine("Smartphone IPhone:");
Smartphone iphone = new Nokia(numero: "99999-2000", modelo: "Iphone 10", imei: "222222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
