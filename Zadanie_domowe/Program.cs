using System;
using System.Diagnostics;
using Zadanie_domowe;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("╔═══════════════════════════════════════════════════════════════╗");
Console.Write("║                   ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("WITAM W PROGRAMIE BELFER                    ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("║");
Console.WriteLine("╠═══════════════════════════════════════════════════════════════╣");
Console.Write("║");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(" Pracownikowi można przyznać ocenę liczbową z przedziału       ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("║");
Console.Write("║");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("      <0..100>  lub w postaci litery od A = 100 do E = 20      ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("║");
Console.WriteLine("║                                                               ║");
Console.Write("║");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("  Wprowadzenie znaku 'q' lub 'Q' spowoduje wyjście z programu. ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("║");
Console.WriteLine("╠═══════════════════════════════════════════════════════════════╣");
Console.Write("║");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(" Imię :                   Nazwisko :                  Płeć :   ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("║");
Console.WriteLine("╠═══════════════════════════════════════════════════════════════╣");
Console.Write("║");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(" Ocena Maksymalna :                                            ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("║");
Console.WriteLine("╠═══════════════════════════════════════════════════════════════╣");
Console.Write("║");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(" Ocena średnia    :                                            ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine ("║");
Console.WriteLine("╠═══════════════════════════════════════════════════════════════╣");
Console.Write("║");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(" Ocena Minimalna  :                                            ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine ("║");
Console.WriteLine("╠═══════════════════════════════════════════════════════════════╣");
Console.Write("║");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(" Ocena Końcowa    :                                            ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("║");
Console.WriteLine("╠═══════════════════════════════════════════════════════════════╣");
Console.Write("║");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(" Podaj ocenę pracownika : ");
int itemX = Console.CursorLeft;
int itemY = Console.CursorTop;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("                                     ║");
Console.WriteLine("╚═══════════════════════════════════════════════════════════════╝");
var employee = new EmployeeFile ("Jan", "Nowak", 'M');
{   
}
employee.GradeAdded += EmployeeGradeAdded;
void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Dodano nową ocenę!");
    Thread.Sleep(3000);
}
Console.ForegroundColor = ConsoleColor.Yellow;
Console.SetCursorPosition(9, itemY - 10);
Console.Write(employee.Name);
Console.SetCursorPosition(38, itemY - 10);
Console.Write(employee.Surname);
Console.SetCursorPosition(62, itemY - 10);
Console.Write(employee.Sex);
while (true) 
{ 
    Console.ForegroundColor = ConsoleColor.White;
    Console.SetCursorPosition(itemX, itemY);
    Console.Write("                     ");
    Console.SetCursorPosition(itemX, itemY);
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        Console.SetCursorPosition(itemX, itemY + 1);
        break;
    }
    Console.SetCursorPosition(itemX, itemY);
    try 
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.SetCursorPosition (itemX, itemY);
        Console.Write($"Exception {e.Message}");
        Thread.Sleep(3000);
        Console.SetCursorPosition(itemX, itemY);
        Console.Write ("                                    ");
    }
    var statistics = employee.GetStatistics();
    if (statistics.Max > -1)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.SetCursorPosition(itemX, itemY - 8);
        Console.WriteLine("      ");
        Console.SetCursorPosition(itemX, itemY - 8);
        Console.WriteLine($"{statistics.Max:N2}");
        Console.SetCursorPosition(itemX, itemY - 6);
        Console.WriteLine("      ");
        Console.SetCursorPosition(itemX, itemY - 6);
        Console.WriteLine($"{statistics.Average:N2}");
        Console.SetCursorPosition(itemX, itemY - 4);
        Console.WriteLine("      ");
        Console.SetCursorPosition(itemX, itemY - 4);
        Console.WriteLine($"{statistics.Min:N2}");
        Console.SetCursorPosition(itemX, itemY - 2);
        Console.WriteLine(" ");
        if(statistics.AverageLetter == 'A') 
        {
            Console.ForegroundColor = ConsoleColor.Green; 
        }
        else
        { 
            if(statistics.AverageLetter == 'B') 
            { 
                Console.ForegroundColor = ConsoleColor.Cyan; 
            }
            else 
            { if (statistics.AverageLetter == 'C') 
                { 
                    Console.ForegroundColor = ConsoleColor.Blue; 
                }
              else 
              { 
                if (statistics.AverageLetter == 'D')
                {
                    Console.ForegroundColor = ConsoleColor.Yellow; 
                }
                else 
                {
                    Console.ForegroundColor = ConsoleColor.Red; }
                }
            }
        }
        Console.SetCursorPosition(itemX, itemY - 2);
        Console.WriteLine($"{statistics.AverageLetter:N2}");
    }

}
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();


