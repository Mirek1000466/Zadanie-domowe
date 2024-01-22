using Zadanie_domowe;

namespace Zadanie_Domowe.Tests
{
    public class Tests
    {
        [Test]
        public void WhenThreePointsAdded_ShouldReturnMinimum()
        {
            // arrsnge
            var user = new Employee("Jan", "Nowak");
            user.AddGrade(5);
            user.AddGrade(10);
            user.AddGrade(20);

            // act
            var Statistics = user.GetStatistics();

            // assert
            Assert.AreEqual(5, Statistics.Min);
        }

        [Test]
        public void WhenTwoPointsAdded_ShouldNegativeMinimumm()
        {
            // arrsnge        
            var user = new Employee("Jan", "Nowak");
            user.AddGrade(10);
            user.AddGrade(-20);

            // act
            var Statistics = user.GetStatistics();

            // assert
            Assert.AreEqual(-20, Statistics.Min);
        }

        [Test]
        public void WhenThreePointsAdded_ShouldReturnMaksimum()
        {
            // arrsnge        
            var user = new Employee("Jan", "Nowak");
            user.AddGrade(5);
            user.AddGrade(10);
            user.AddGrade(20);

            // act
            var Statistics = user.GetStatistics();

            // assert
            Assert.AreEqual(20, Statistics.Max);
        }

        [Test]
        public void WhenNegativePointsAdded_ShouldReturnMaksimum()
        {
            // arrsnge        
            var user = new Employee("Jan", "Nowak");
            user.AddGrade(10);
            user.AddGrade(-20);

            // act
            var Statistics = user.GetStatistics();

            // assert
            Assert.AreEqual(10, Statistics.Max);
        }

        [Test]
        public void WhenTwoPointsAdded_ShouldReturnAverage()
        {
            // arrsnge        
            var user = new Employee("Jan", "Nowak");
            user.AddGrade(10);
            user.AddGrade(20);

            // act
            var Statistics = user.GetStatistics();

            // assert
            Assert.AreEqual(15, Statistics.Average);
        }

        [Test]
        public void WhenNegativePointsAdded_ShouldReturnAverage()
        {
            // arrsnge        
            var user = new Employee("Jan", "Nowak");
            user.AddGrade(10);
            user.AddGrade(-20);

            // act
            var Statistics = user.GetStatistics();

            // assert
            Assert.AreEqual(-5, Statistics.Average);
        }
    }
}