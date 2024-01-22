using Zadanie_domowe;

var employee = new Employee("Jan", "Nowak");
employee.AddGrade(2);
employee.AddGrade(3);
employee.AddGrade(5);
var Statistics = employee.GetStatistics();
Console.WriteLine($"Imię : {employee.Name}  Nazwisko : {employee.Surname}");
Console.WriteLine("    O C E N Y");
Console.WriteLine($"Minimalna  {Statistics.Min}");
Console.WriteLine($"Maksymalna {Statistics.Max}");
Console.WriteLine($"Średnia    {Statistics.Average:N2}");