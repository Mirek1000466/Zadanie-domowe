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
            this.grades.Add(grade);

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
