namespace Zadanie_domowe
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100) 
            {
                this.grades.Add(grade);
            }
            else 
            {
                Console.WriteLine($"The added value ({grade}) should be in the range <0..100>."); 
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
                Console.WriteLine($"String ({grade}) is not float.");
            }
        }
        public void AddGrade(int grade)
        {
            float resunlt = grade;
            this.AddGrade(resunlt);
        }
        public void AddGrade(double grade)
        {
            float resunlt = (float)grade;
            this.AddGrade(resunlt);
        }

        public Statistics GetStatistics()
        {
            var statsistics = new Statistics();
            statsistics.Min = float.MaxValue;
            statsistics.Max = float.MinValue;
            statsistics.Average = 0;
            foreach (var grade in this.grades)
            {
                statsistics.Average += grade;
                statsistics.Min = Math.Min(statsistics.Min, grade);
                statsistics.Max = Math.Max(statsistics.Max, grade);
            }
            statsistics.Average /= this.grades.Count;

            return statsistics;
        }

    }
}
