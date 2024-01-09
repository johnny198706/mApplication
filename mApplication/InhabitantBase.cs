namespace mApplication
{
    public abstract class InhabitantBase : IInhabitant
    {
        public delegate void MeasurementAddedDelegate(object senser, EventArgs args);
        public abstract event InhabitantBase.MeasurementAddedDelegate MeasurementAdded;
        public InhabitantBase(string name, string surname, string adress)
        {
            this.Name = name;
            this.Surname = surname;
            this.Adress = adress;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public string Adress { get; private set; }

        public abstract void AddMeasurement(float measurement);

        public void AddMeasurement(string measurement)
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
                        throw new Exception(" Wrong Letter");
                }
            }
            else
            {
                throw new Exception(" string is not float");
            }
        }


        public abstract void AddMeasurement(double measurement);


        public abstract void AddMeasurement(int measurement);


        public abstract void AddMeasurement(long measurement);

        public abstract Statistics GetStatistics();

    }
}
