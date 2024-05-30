﻿using DesafioPOO.Models;

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia("11999996666", "N95", "777666555444321", 32);
nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("Sbrubles");

Console.WriteLine("__________________________________________");

Console.WriteLine("iPhone");
Smartphone iphone = new Iphone("+5511988885555", "Caro", "321321321654654654", 64);
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("Twitch");