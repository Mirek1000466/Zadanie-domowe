using System.Reflection.Metadata;

namespace Zadanie_domowe
{
    public class EmployeeMemory : EmployeeBase
    {   private List<float> grades = new List<float>();
        public EmployeeMemory(string name, string surname, char sex)
            : base(name, surname, sex)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Błąd wartości <0..100>.");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                if (grade.Length == 1)
                {
                    this.AddGrade(grade[0]);
                }
                else
                {
                    throw new Exception("Błąd <0..100> lub <A..E>.");
                }
            }
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Błąd litery <A..E>.");
            }
        }

        public override void AddGrade(double grade)
        {
            float resunlt = (float)grade;
            this.AddGrade(resunlt);
        }

        public override Statistics GetStatistics()
        {
            var statsistics = new Statistics();
            statsistics.Min = 100;
            statsistics.Max = -1;
            statsistics.Average = 0;
            foreach (var grade in this.grades)
            {
                statsistics.Average += grade;
                statsistics.Min = Math.Min(statsistics.Min, grade);
                statsistics.Max = Math.Max(statsistics.Max, grade);
            }
            statsistics.Average /= this.grades.Count;
            switch (statsistics.Average)
            {
                case var average when average >= 81:
                    statsistics.AverageLetter = 'A';
                    break;
                case var average when average >= 61:
                    statsistics.AverageLetter = 'B';
                    break;
                case var average when average >= 41:
                    statsistics.AverageLetter = 'C';
                    break;
                case var average when average >= 21:
                    statsistics.AverageLetter = 'D';
                    break;
                default:
                    statsistics.AverageLetter = 'E';
                    break;
            }
            return statsistics;
        }
    }
}
