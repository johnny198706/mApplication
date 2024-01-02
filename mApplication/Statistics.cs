namespace mApplication
{
    public class Statistics
    {
        public float Min { get; set; }

        public float Max { get; set; }

        public float Sum { get; set; }
        public int Count { get; set; }

        public float Average
        {
            get
            {
                return this.Sum / this.Count;
            }
        }

        public char AverageLetter
        {
            get
            {
                switch (this.Average)
                {
                    case var average when average >= 900:
                        return 'J';
                    case var average when average >= 800:
                        return 'I';
                    case var average when average >= 700:
                        return 'H';
                    case var average when average >= 600:
                        return 'G';
                    case var average when average >= 500:
                        return 'F';
                    case var average when average >= 400:
                        return 'E';
                    case var average when average >= 300:
                        return 'D';
                    case var average when average >= 200:
                        return 'C';
                    case var average when average >= 100:
                        return 'B';
                    default:
                        return 'A';

                }
            }
        }

        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }

        public void AddMeasurement(float measurement)
        {
            this.Count++;
            this.Sum += measurement;
            this.Min = Math.Min(measurement, this.Min);
            this.Max = Math.Max(measurement, this.Max);


        }
    }
}
