using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone(numero: "(11)99772-1425", modelo: "XR", imei: "448811524451554",memoria: 128);
iphone.Dados();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Pottencial-Dio");

Console.WriteLine();

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("(15)94287-4281", "Nokia 5.4 Dual", "123456789482485", 64);
nokia.Dados();
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine();

Console.WriteLine("Smartphone Samsung:");
Samsung samsung = new Samsung("(21)93281-5821", "Galaxy S20", "259874523896578", 256);
samsung.Dados();
samsung.Ligar();
samsung.InstalarAplicativo("GitHub");

