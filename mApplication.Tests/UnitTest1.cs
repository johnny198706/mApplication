namespace mApplication.Tests
{
    public class Tests
    {

        [Test]
        public void WhichMeasurementIsMax()
        {
            //arrange
            var inhabitant = new InhabitantInMemory("Marcin", "Stefañski", "S³upsk,ul.Oliwna 2");
            inhabitant.AddMeasurement(10);
            inhabitant.AddMeasurement(15);

            //act
            var statistics = inhabitant.GetStatistics();

            //assert
            Assert.That(statistics.Max, Is.EqualTo(15));
        }
    }
}