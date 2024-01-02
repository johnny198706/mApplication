namespace mApplication
{
    public interface IInhabitant
    {
        string Name { get; }

        string Surname { get; }

        string Adress { get; }

        void AddMeasurement(float measurement);

        void AddMeasurement(string measurement);

        public event InhabitantBase.MeasurementAddedDelegate MeasurementAdded;
        void AddMeasurement(double measurement);

        void AddMeasurement(int measurement);

        void AddMeasurement(long measurement);


        Statistics GetStatistics();
    }
}
