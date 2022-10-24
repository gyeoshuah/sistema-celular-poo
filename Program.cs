using DesafioPOO.Models;


Console.WriteLine ("Iphone:");
Smartphone iphone = new Iphone("11 99876-5432", "11 Pro Max","111AAA",256);
iphone.InstalarAplicativo("Call of Duty Mobile");
iphone.Ligar();

Console.WriteLine("\n");

Console.WriteLine ("Nokia:");
Smartphone nokia = new Nokia("11 91234-5678", "Lumia 520","222BBB",128);
nokia.InstalarAplicativo("Spotify");
nokia.ReceberLigacao();