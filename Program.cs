using DesafioPOO.Models;

Console.WriteLine("Iphone:\n");

Smartphone iPhone = new Iphone(numero:"123456789", modelo:"iPhone 12", imei:"123456789012345", memoria:128);
iPhone.Ligar();
iPhone.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Nokia:\n");

Smartphone nokia = new Nokia(numero:"987654321", modelo:"Nokia 3310", imei:"987654321098765", memoria:32);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");