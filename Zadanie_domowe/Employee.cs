using System.Diagnostics;

namespace Zadanie_domowe
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public string name { get; private set; }

        public string surname { get; private set; }

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

        public Statistics GetStatisticsWithForEatch()
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
        public Statistics GetStatisticsWithFor()
        {
            var statsistics = new Statistics();
            statsistics.Min = float.MaxValue;
            statsistics.Max = float.MinValue;
            statsistics.Average=0;
            for (int index=0;index<this.grades.Count ;index++ ) 
            {
                var grade = this.grades[index];
                statsistics.Average+=grade;
                statsistics.Min = Math.Min(statsistics.Min, grade);
                statsistics.Max = Math.Max(statsistics.Max, grade);
            }
            statsistics.Average /= this.grades.Count;
            return statsistics;
        }
        public Statistics GetStatisticsWithWhil()
        {
            var statsistics = new Statistics();
            statsistics.Min = float.MaxValue;
            statsistics.Max = float.MinValue;
            statsistics.Average=0;
            var index=0;
            while (index<this.grades.Count) 
            {
                var grade = this.grades[index];
                statsistics.Average += grade;
                statsistics.Min = Math.Min(statsistics.Min, grade);
                statsistics.Max = Math.Max(statsistics.Max, grade);
                index++;
            }statsistics.Average /= this.grades.Count;
            return statsistics;
        }
        public Statistics GetStatisticsWithDoWhil()
        {
            var statsistics = new Statistics();
            statsistics.Min = float.MaxValue;
            statsistics.Max = float.MinValue;
            statsistics.Average = 0;
            var index = 0;
            if (this.grades.Count > index)
            {
                do
                {
                    var grade = this.grades[index];
                    statsistics.Average += grade;
                    statsistics.Min = Math.Min(statsistics.Min, grade);
                    statsistics.Max = Math.Max(statsistics.Max, grade);
                    index++;
                }
                while (index < this.grades.Count);
                statsistics.Average /= this.grades.Count;

            }
            return statsistics;
        }


    }
}
