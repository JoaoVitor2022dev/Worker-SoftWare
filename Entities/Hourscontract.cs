namespace Primeiro.Entities
{
    class Hourscontract
    {
        public DateTime Date { get; set; }
        public double ValuePeHour { get; set; }
        public int Hours { get; set; }

        public Hourscontract()
        {}
        public Hourscontract(DateTime date, double valuePeHour, int hours )
        {
            Date = date; 
            ValuePeHour = valuePeHour; 
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePeHour;
        }
    }
}