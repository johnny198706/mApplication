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
                Console.WriteLine(" Incorrect measurement value");
            }
        }

        public new void AddMeasurement(string measurement)
        {
            base.AddMeasurement(measurement);
        }

        public override void AddMeasurement(double measurement)
        {
            float measurementAsFloat = (float)measurement;
            this.AddMeasurement(measurementAsFloat);
        }

        public override void AddMeasurement(int measurement)
        {
            float measurementAsFloat = (float)measurement;
            this.AddMeasurement(measurementAsFloat);
        }

        public override void AddMeasurement(long measurement)
        {
            float measurementAsFloat = (float)measurement;
            this.AddMeasurement(measurementAsFloat);
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
