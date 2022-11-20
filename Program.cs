using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//Nokia
Smartphone nokia = new Nokia(numero:"19 994616577", modelo: "1", imei: "1111111", memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
Smartphone iphone = new Iphone(numero:"19 994616577", modelo: "2", imei: "22222222", memoria:128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

