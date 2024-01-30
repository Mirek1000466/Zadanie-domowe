using System.Diagnostics;

namespace Zadanie_domowe
{
    public class Employee : IEmployee
    {
        private List<float> grades = new List<float>();
        
        public Employee(string name, string surname, char sex)            
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Sex { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100) 
            {
                this.grades.Add(grade);
            }
            else 
            {
                throw new Exception("Błąd <0..100> lub <A..E>.");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float resunlt))
            {
                    this.AddGrade(resunlt);
            }
            else
            {
                if (grade.Length == 1)
                {
                    var charakter = grade[0];
                    this.AddGrade(charakter);
                }
                else
                {
                        throw new Exception("Błąd <0..100> lub <A..E>.");
                }
            }
        }

            public void AddGrade(char grade)
            {
                switch(grade)
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
        public void AddGrade(double grade)
        {
            float resunlt = (float)grade;
            this.AddGrade(resunlt);
        }

        public Statistics GetStatistics()
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
                default :
                    statsistics.AverageLetter = 'E';
                    break;
                
            }
            return statsistics;
        }


    }
}
