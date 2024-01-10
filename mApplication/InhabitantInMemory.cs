namespace mApplication
{
    public class InhabitantInMemory : InhabitantBase
    {
        public override event MeasurementAddedDelegate MeasurementAdded;

        private List<float> measurements = new List<float>();
        public InhabitantInMemory(string name, string surname, string adress)
            : base(name, surname, adress)
        {

        }

        public override void AddMeasurement(float measurement)
        {
            if (measurement >= 0 && measurement <= 1100)
            {
                this.measurements.Add(measurement);
                if (MeasurementAdded != null)
                {
                    MeasurementAdded(this, new EventArgs());
                }
            }
            else
            {
                Console.WriteLine(" The given value is outside the range from 0 to 1100");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();


            foreach (var measurement in this.measurements)
            {
                statistics.AddMeasurement(measurement);
            }

            return statistics;
        }
    }
}
