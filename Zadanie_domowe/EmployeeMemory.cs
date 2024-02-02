using System.Reflection.Metadata;

namespace Zadanie_domowe
{
    public class EmployeeMemory : EmployeeBase
    {
        public override event EmployeeBase.GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();
        public EmployeeMemory(string name, string surname, char sex)
            : base(name, surname, sex)
        {          
        }

        private void WriteMessage(string message) 
        {
            Console.WriteLine(message);
        }
        private void WriteMessage1(string message)
        {
            Console.WriteLine(message.ToUpper());
        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
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
            foreach (var grade in this.grades) 
            {
                statsistics.AddGrade(grade);
            }
            return statsistics;
        }
    }
}
