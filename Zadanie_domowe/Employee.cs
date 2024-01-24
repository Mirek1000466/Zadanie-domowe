namespace Zadanie_domowe
{
    public class Employee
    {
        private List<float> Grades = new List<float>();

        public Employee(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float Grade)
        {
            if (Grade >= 0 && Grade <= 100) 
            {
                this.Grades.Add(Grade);
            }
            else 
            {
                Console.WriteLine($"The added value ({Grade}) should be in the range <0..100>."); 
            }
        }

        public void AddGrade(string Grade)
        {
            if (float.TryParse(Grade, out float resunlt))
            {
                this.AddGrade(resunlt);
            }
            else
            {
                Console.WriteLine($"String ({Grade}) is not float.");
            }
        }
        public void AddGrade(int Grade)
        {
            float resunlt = Grade;
            this.AddGrade(resunlt);
        }
        public void AddGrade(double Grade)
        {
            float resunlt = (float)Grade;
            this.AddGrade(resunlt);
        }

        public Statistics GetStatistics()
        {
            var Statsistics = new Statistics();
            Statsistics.Min = float.MaxValue;
            Statsistics.Max = float.MinValue;
            Statsistics.Average = 0;
            foreach (var Grade in this.Grades)
            {
                Statsistics.Average += Grade;
                Statsistics.Min = Math.Min(Statsistics.Min, Grade);
                Statsistics.Max = Math.Max(Statsistics.Max, Grade);
            }
            Statsistics.Average /= this.Grades.Count;

            return Statsistics;
        }

    }
}
