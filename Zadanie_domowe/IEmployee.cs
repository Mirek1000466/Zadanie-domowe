using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Zadanie_domowe.EmployeeBase;

namespace Zadanie_domowe
{
    internal interface IEmployee
    {
        event GradeAddedDelegate GradeAdded;
        string Name { get; }
        string Surname { get; }
        char Sex { get; }
        void AddGrade(float grade);
        void AddGrade(string grade);
        void AddGrade(char grade);
        void AddGrade(double grade);        
        Statistics GetStatistics();
    }
}
