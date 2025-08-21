using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
var iPhone = new Iphone("123", "I6", "jkjhkhj", 15);
var nokia = new Nokia("456", "Qualquer", "jhkhkhkhkhkhk", 16);

iPhone.Ligar();
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Whats");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whats");