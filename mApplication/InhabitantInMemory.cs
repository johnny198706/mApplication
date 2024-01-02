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
            if (measurement >= 0 && measurement <= 1001)
            {
                this.measurements.Add(measurement);
                if (MeasurementAdded != null)
                {
                    MeasurementAdded(this, new EventArgs());
                }
            }
            else
            {
                Console.WriteLine("Incorrect measurement value");
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
            var statistics = new Statistics();


            foreach (var measurement in this.measurements)
            {
                statistics.AddMeasurement(measurement);
            }

            return statistics;
        }
    }
}
