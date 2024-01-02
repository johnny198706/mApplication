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
            if (measurement >= 0 && measurement <= 10000)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(measurement);
                    writer.Close();
                }
                if (MeasurementAdded != null)
                {
                    MeasurementAdded(this, new EventArgs());
                }
                else
                {
                    Console.WriteLine("Incorrect measurement value");
                }
            }
        }

        public override void AddMeasurement(string measurement)
        {
            if (float.TryParse(measurement, out float result))
            {
                this.AddMeasurement(result);
            }
            else if (char.TryParse(measurement, out char charResult))
            {
                switch (charResult)
                {
                    case 'A':
                    case 'a':
                        AddMeasurement(100);
                        break;
                    case 'B':
                    case 'b':
                        AddMeasurement(200);
                        break;
                    case 'C':
                    case 'c':
                        AddMeasurement(300);
                        break;
                    case 'D':
                    case 'd':
                        AddMeasurement(400);
                        break;
                    case 'E':
                    case 'e':
                        AddMeasurement(500);
                        break;
                    case 'F':
                    case 'f':
                        AddMeasurement(600);
                        break;
                    case 'G':
                    case 'g':
                        AddMeasurement(700);
                        break;
                    case 'H':
                    case 'h':
                        AddMeasurement(800);
                        break;
                    case 'I':
                    case 'i':
                        AddMeasurement(900);
                        break;
                    case 'J':
                    case 'j':
                        AddMeasurement(1000);
                        break;
                    default:
                        throw new Exception("Wrong Letter");
                }
            }
            else
            {
                throw new Exception("string is not float");
            }
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
