using DesafioPOO.Models;
using trilha_net_poo_desafio.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

MenuNokia menuNokia = new MenuNokia("11999999999", "Nokia 6.1", "1234567890", 64);
menuNokia.ExibirMenu();

System.Console.WriteLine("-----------------------------------");

Smartphone iphone = new Iphone("11988888888", "iPhone 12", "0987654321", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");