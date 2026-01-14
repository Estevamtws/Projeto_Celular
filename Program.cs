using System.Formats.Asn1;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia n1 = new Nokia("123456789");
Iphone i1 = new Iphone("987654321");

n1.Numero = "123456789";
n1.Modelo = "Nokia XYZ";
n1.IMEI = "123456789012345";
n1.Memoria = 64;
n1.Ligar();
n1.InstalarAplicativo("WhatsApp");

i1.Numero = "987654321";
i1.Modelo = "iPhone ABC";
i1.IMEI = "543210987654321";
i1.Memoria = 128;
i1.Ligar();
i1.InstalarAplicativo("Instagram");