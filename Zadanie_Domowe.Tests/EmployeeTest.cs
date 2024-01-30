using Zadanie_domowe;

namespace Zadanie_Domowe.Tests
{
    public class Tests
    {
        [Test]
        public void WhenCharAdded_ShouldAddedpoints()
        {
            // arrsnge
            var employee = new Employee("Jan","Nowak",'M');
            employee.AddGrade('A');


            // act
            var user = employee.GetStatistics();
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(100, statistics.Min);
            Assert.AreEqual(100, statistics.Min);
            Assert.AreEqual(100, statistics.Average);
            Assert.AreEqual('A', statistics.AverageLetter);
        }

        [Test]
        public void WhenStringAdded_ShouldAddedPoints()
        {
            // arrsnge
            var employee = new Employee("Jan", "Nowak", 'M');
            employee.AddGrade("25,75");


            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(25.75, statistics.Min);
            Assert.AreEqual(25.75, statistics.Min);
            Assert.AreEqual(25.75, statistics.Average);
            Assert.AreEqual('D', statistics.AverageLetter);
        }

        [Test]
        public void WhenThreePointsAdded_ShouldReturnMinimum()
        {
            // arrsnge
            var user = new Employee("Jan", "Nowak", 'M');
            user.AddGrade(5);
            user.AddGrade(10);
            user.AddGrade(20);

            // act
            var Statistics = user.GetStatistics();

            // assert
            Assert.AreEqual(5, Statistics.Min);
        }

        [Test]
        public void WhenThreePointsAdded_ShouldReturnMaksimum()
        {
            // arrsnge        
            var user = new Employee("Jan", "Nowak", 'M');
            user.AddGrade(5);
            user.AddGrade(10);
            user.AddGrade(20);

            // act
            var Statistics = user.GetStatistics();

            // assert
            Assert.AreEqual(20, Statistics.Max);
        }

        
        [Test]
        public void WhenTwoPointsAdded_ShouldReturnAverage()
        {
            // arrsnge        
            var user = new Employee("Jan", "Nowak", 'M');
            user.AddGrade(10);
            user.AddGrade(20);

            // act
            var Statistics = user.GetStatistics();

            // assert
            Assert.AreEqual(Math.Round(15.000, 2), Math.Round(Statistics.Average, 2));
        }

        [Test]
        public void WhenNegativePointsAdded_ShouldReturnAverage()
        {
            // arrsnge        
            var user = new Employee("Jan", "Nowak", 'M');
            user.AddGrade(10);
            user.AddGrade(-20);

            // act
            var Statistics = user.GetStatistics();

            // assert
            Assert.AreEqual(10 , Math.Round(Statistics.Average, 2));
        }
    }
}