using Zadanie_domowe;

var employee = new Employee("Jan", "Nowak");
employee.AddGrade("200sdfgfd");
employee.AddGrade(29.64574567);
employee.AddGrade(5);
var Statistics = employee.GetStatistics();
Console.WriteLine($"Imię : {employee.Name}  Nazwisko : {employee.Surname}");
Console.WriteLine("    O C E N Y");
Console.WriteLine($"Minimalna  {Statistics.Min:N2}");
Console.WriteLine($"Maksymalna {Statistics.Max:N2}");
Console.WriteLine($"Średnia    {Statistics.Average:N2}");