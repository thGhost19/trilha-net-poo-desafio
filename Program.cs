using DesafioPOO.Models;

Smartphone nokia = new Nokia("12345", "Nokia 3310", "111111111", 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Smartphone iphone = new Iphone("67890", "iPhone 14", "222222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");