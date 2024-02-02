namespace Zadanie_domowe
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public float Count { get; private set; }
        public float Average 
        { 
            get 
            {
                return this.Sum / this.Count;
            } 
        }
        public char AverageLetter 
        {
            get 
            {
                switch (this.Average)
                {
                    case var average when average >= 81:
                        return 'A';
                    case var average when average >= 61:
                        return 'B';
                    case var average when average >= 41:
                        return 'C';
                    case var average when average >= 21:
                        return 'D';
                    default:
                        return 'E';
                }
            }
        }
        public Statistics()
        {
            this.Sum = 0;
            this.Count = 0;
            this.Min = float.MaxValue; 
            this.Max = float.MinValue;
        }
        public void AddGrade(float grade) 
        {
            this.Count++;
            this.Sum += grade;
            this.Min = Math.Min(this.Min, grade);
            this.Max = Math.Max(this.Max, grade);
        }
    }
}
