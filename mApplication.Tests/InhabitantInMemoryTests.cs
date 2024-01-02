using mApplication;

namespace mApplication.Tests
{
    public class InhabitantInMemoryTests
    {
        [Test]
        public void WhichMeasurementIsMaxI()
        {
            //arrange
            var inhabitant = new InhabitantInMemory("Marcin", "Stefański", "Słupsk,ul.Oliwna 2");
            inhabitant.AddMeasurement(200);
            inhabitant.AddMeasurement(100);
            inhabitant.AddMeasurement(300);
            inhabitant.AddMeasurement(600);
            inhabitant.AddMeasurement(400);
            inhabitant.AddMeasurement(500);
            inhabitant.AddMeasurement(300);

            //act
            var statistics = inhabitant.GetStatistics();

            //assert
            Assert.That(statistics.Max, Is.EqualTo(600));
        }
        [Test]
        public void WhichMeasurementIsMinI()
        {
            //arrange
            var inhabitant = new InhabitantInMemory("Marcin", "Stefański", "Słupsk,ul.Oliwna 2");
            inhabitant.AddMeasurement(200);
            inhabitant.AddMeasurement(100);
            inhabitant.AddMeasurement(300);
            inhabitant.AddMeasurement(600);
            inhabitant.AddMeasurement(400);
            inhabitant.AddMeasurement(500);
            inhabitant.AddMeasurement(300);

            //act
            var statistics = inhabitant.GetStatistics();

            //assert
            Assert.That(statistics.Min, Is.EqualTo(100));
        }
        [Test]
        public void WhichMeasurementIsAverage()
        {
            //arrange
            var inhabitant = new InhabitantInMemory("Marcin", "Stefański", "Słupsk,ul.Oliwna 2");
            inhabitant.AddMeasurement(200);
            inhabitant.AddMeasurement(100);
            inhabitant.AddMeasurement(300);
            inhabitant.AddMeasurement(600);
            inhabitant.AddMeasurement(400);
            inhabitant.AddMeasurement(500);
            inhabitant.AddMeasurement(300);

            //act
            var statistics = inhabitant.GetStatistics();

            //assert
            Assert.That(statistics.Average, Is.EqualTo(342.857143f));
        }
        [Test]
        public void WhatIsAverageLetter()
        {
            //arrange
            var inhabitant = new InhabitantInMemory("Marcin", "Stefański", "Słupsk,ul.Oliwna 2");
            inhabitant.AddMeasurement(200);
            inhabitant.AddMeasurement(100);
            inhabitant.AddMeasurement(300);
            inhabitant.AddMeasurement(600);
            inhabitant.AddMeasurement('d');
            inhabitant.AddMeasurement(500);
            inhabitant.AddMeasurement(300);

            //act
            var statistics = inhabitant.GetStatistics();

            //assert
            Assert.That(statistics.AverageLetter, Is.EqualTo('D'));
        }
    }
}
