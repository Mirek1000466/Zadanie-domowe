namespace Zadanie_domowe
{
    public class Supervisor : IEmployee
    {   List<float> grades = new List<float>();
        public Supervisor(string name, string sourname, char sex)
        {
            this.Name = name;
            this.Surname = sourname;
            this.Sex = sex;
        }
        public string Name {  get; private set; }

        public string Surname { get; private set; }

        public char Sex { get; private set; }

        public void AddGrade(float grade)
        {
            grades.Add(grade);            
        }

        public void AddGrade(string grade)
        {
            if (grade.Contains('-'))
            {
                grade = grade.Remove(grade.IndexOf('-'),1);
                if (grade.Length == 1) 
                {
                    switch(grade) 
                    {
                        case "6":
                            this.AddGrade(95);
                            break;
                        case "5":
                            this.AddGrade(75);
                            break;
                        case "4":
                            this.AddGrade(55);
                            break;
                        case "3":
                            this.AddGrade(35);
                            break;
                        case "2":
                            this.AddGrade(15);
                            break;                        
                        throw new Exception("Błąd <-2..-6>");
                    }
                }
            }
            else 
            {
                if (grade.Contains('+')) 
                {
                    grade = grade.Remove(grade.IndexOf('+'), 1);
                    if(grade.Length == 1) 
                    {
                        switch(grade) 
                        {
                            case "5":
                                this.AddGrade(85); 
                                break;
                            case "4":
                                this.AddGrade(65);
                                break;
                            case "3":
                                this.AddGrade(45);
                                break;
                            case "2":
                                this.AddGrade(25);
                                break;
                            case "1":
                                this.AddGrade(5);
                                break;
                        throw new Exception("Błąd <+1..+5>");
                        }
                    }
                }
            } 
            if (grade.Length == 1) 
            {
               switch(grade) 
                {
                    case "6":
                        this.AddGrade(100);
                        break;
                    case "5":
                        this.AddGrade(80);
                        break;
                    case "4":
                        this.AddGrade(60);
                        break;
                    case "3":
                        this.AddGrade(40);
                        break;
                    case "2":
                        this.AddGrade(20);
                        break;
                    case "1":
                        this.AddGrade(0);
                        break;
                    throw new Exception("Błąd <1..6>");
                } 
            }
            else 
            {
                throw new Exception("Błąd <1..6>.");
            }                
        }

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public Statistics GetStatistics()
        {
            return new Statistics();
        }
    }
}
