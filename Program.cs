using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.InstalarAplicativo("Instagram");
nokia.listaraplicativos();

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iPhone = new Iphone(numero: "4987", modelo: "Modelo 2", imei: "22222222222", memoria: 128);
iPhone.Ligar();
iPhone.InstalarAplicativo("Telegram");
iPhone.InstalarAplicativo("Tik Tok");
iPhone.listaraplicativos();
iPhone.RemoverAplicativos("Telegrm");
iPhone.RemoverAplicativos("Telegram");
iPhone.listaraplicativos();