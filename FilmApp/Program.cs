using FilmApp;

Film film = new Film();
film.Cim = "Inception";
film.HosszPercben = 148;

Film film1 = new Film();
film1.Cim = "The Matrix";
film1.HosszPercben = 136;

Console.WriteLine($"Film címe: {film.Cim}, Hossza: {film.HosszPercben} perc");
Console.WriteLine($"Film címe: {film1.Cim}, Hossza: {film1.HosszPercben} perc");