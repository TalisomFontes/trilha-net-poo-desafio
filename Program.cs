using DesafioPOO.Models;

// Testado!!

Nokia nokia = new Nokia("84325968", "Nokia 3310", "11122222", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Iphone iphone = new Iphone("", "Iphone 11", "654321", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

