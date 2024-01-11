namespace mApplication
{
    public class InhabitantInFile : InhabitantBase
    {
        private const string fileName = "measurement.txt";
        public override event MeasurementAddedDelegate MeasurementAdded;
        public InhabitantInFile(string name, string surname, string adress)
            : base(name, surname, adress)
        {

        }

        public override void AddMeasurement(float measurement)
        {
            if (measurement >= 0 && measurement <= 1100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(measurement);
                }
                if (MeasurementAdded != null)
                {
                    MeasurementAdded(this, new EventArgs());
                }

            }
            else
            {
                throw new Exception(" The given value is outside the range from 0 to 1100");
            }
        }

        public override Statistics GetStatistics()
        {
            var measurementFromFile = this.ReadMeasurementFromFile();
            var result = this.CountStatistics(measurementFromFile);
            return result;
        }
        private List<float> ReadMeasurementFromFile()
        {
            var measurements = new List<float>();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        measurements.Add(float.Parse(line));
                        line = reader.ReadLine();
                    }
                }
            }
            return measurements;
        }

        private Statistics CountStatistics(List<float> measurements)
        {
            var statistics = new Statistics();

            foreach (var measurement in measurements)
            {
                statistics.AddMeasurement(measurement);
            }

            return statistics;
        }
    }
}
