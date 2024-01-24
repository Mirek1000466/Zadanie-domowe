using Zadanie_domowe;

var Employee = new Employee("Jan", "Nowak");
Employee.AddGrade("200");
Employee.AddGrade(29.64574567);
Employee.AddGrade(5);
var Statistics = Employee.GetStatistics();
Console.WriteLine($"Imię : {Employee.Name}  Nazwisko : {Employee.Surname}");
Console.WriteLine("    O C E N Y");
Console.WriteLine($"Minimalna  {Statistics.Min:N2}");
Console.WriteLine($"Maksymalna {Statistics.Max:N2}");
Console.WriteLine($"Średnia    {Statistics.Average:N2}");