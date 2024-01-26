using Zadanie_domowe;

Console.WriteLine("╔═════════════════════════════════════════════════════════╗");
Console.WriteLine("║                WITAM W PROGRAMIE BELFER                 ║");
Console.WriteLine("╠═════════════════════════════════════════════════════════╣");
Console.WriteLine("║ Pracownikowi można przyznać ocenę liczbową z przedziału ║");
Console.WriteLine("║   <0..100>  lub w postaci litery od A = 100 do E = 20   ║");
Console.WriteLine("║                                                         ║");
Console.WriteLine("║   Wprowadzenie  znaku q spowoduje wyjście z programu.   ║");
Console.WriteLine("╠═════════════════════════════════════════════════════════╣");
Console.Write("║ Podaj ocenę pracownika : ");
int itemX = Console.CursorLeft;
int itemY = Console.CursorTop;
Console.WriteLine("                               ║");
Console.WriteLine("╠═════════════════════════════════════════════════════════╣");
Console.WriteLine("║ Ocena Minimalna  :                                      ║");
Console.WriteLine("╠═════════════════════════════════════════════════════════╣");
Console.WriteLine("║ Ocena Maksymalna :                                      ║");
Console.WriteLine("╠═════════════════════════════════════════════════════════╣");
Console.WriteLine("║ Ocena Średnia    :                                      ║");
Console.WriteLine("╠═════════════════════════════════════════════════════════╣");
Console.WriteLine("║ Ocena Końcowa    :                                      ║");
Console.WriteLine("╚═════════════════════════════════════════════════════════╝");
var employee = new Employee();
while(true) 
{ 
    Console.SetCursorPosition(itemX, itemY);
    Console.Write("      ");
    Console.SetCursorPosition(itemX, itemY);
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        Console.SetCursorPosition(itemX, itemY + 10);
        break;
    }
    Console.SetCursorPosition(itemX, itemY);
    employee.AddGrade(input);
    var statistics = employee.GetStatistics();
    if(statistics.Max > -1)
    {
        Console.SetCursorPosition(itemX, itemY + 2);
        Console.WriteLine("      ");
        Console.SetCursorPosition(itemX, itemY + 2);
        Console.WriteLine($"{statistics.Min:N2}");
        Console.SetCursorPosition(itemX, itemY + 4);
        Console.WriteLine("      ");
        Console.SetCursorPosition(itemX, itemY + 4);
        Console.WriteLine($"{statistics.Max:N2}");
        Console.SetCursorPosition(itemX, itemY + 6);
        Console.WriteLine("      ");
        Console.SetCursorPosition(itemX, itemY + 6);
        Console.WriteLine($"{statistics.Average:N2}");
        Console.SetCursorPosition(itemX, itemY + 8);
        Console.WriteLine(" ");
        Console.SetCursorPosition(itemX, itemY + 8);
        Console.WriteLine($"{statistics.AverageLetter:N2}");
    }

}
Console.WriteLine();


