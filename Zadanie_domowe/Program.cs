using Zadanie_domowe;

var employee = new Employee("Jan", "Nowak");
employee.AddGrade("200");
employee.AddGrade(29.64574567);
employee.AddGrade(5);
var statistics = employee.GetStatistics();
Console.WriteLine($"Imię : {employee.name}  Nazwisko : {employee.surname}");
Console.WriteLine("         OCENY ");
Console.WriteLine($"Minimalna  {statistics.Min:N2}");
Console.WriteLine($"Maksymalna {statistics.Max:N2}");
Console.WriteLine($"Średnia    {statistics.Average:N2}");
