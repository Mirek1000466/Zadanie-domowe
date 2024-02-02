using System.Diagnostics.Metrics;
using System.Linq.Expressions;

namespace Zadanie_domowe
{
    public class EmployeeFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public override event GradeAddedDelegate GradeAdded;
        public EmployeeFile(string name, string surname, char sex)
            : base(name, surname, sex)
        {

        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
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
                    throw new Exception($"Błąd <0..100> lub <A..E>.");
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
                default: throw new Exception("Błąd danych <A..E>");
            }
        }
        public override void AddGrade(double grade)
        {
            float resunlt = (float)grade;
            this.AddGrade(resunlt);
        }
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        statistics.AddGrade(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return statistics;
        }
    }
}
