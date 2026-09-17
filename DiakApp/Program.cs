using DiakApp;

Diak ParameterNelkul = new Diak();
Diak EgyParameteres = new Diak(4.0);
Diak KetParameteres = new Diak("Tudhou R. Ákos",1.0);

EgyParameteres.Atlag = 4.0;
Console.WriteLine(ParameterNelkul.Nev + " " + ParameterNelkul.Atlag);
Console.WriteLine(EgyParameteres.Nev + " " + EgyParameteres.Atlag);
Console.WriteLine(KetParameteres.Nev + " " + KetParameteres.Atlag);
