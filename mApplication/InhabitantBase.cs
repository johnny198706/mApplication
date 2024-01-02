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

        public abstract void AddMeasurement(string measurement);


        public abstract void AddMeasurement(double measurement);


        public abstract void AddMeasurement(int measurement);


        public abstract void AddMeasurement(long measurement);

        public abstract Statistics GetStatistics();

    }
}
