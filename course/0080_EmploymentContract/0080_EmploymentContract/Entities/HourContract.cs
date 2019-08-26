using System;

namespace _0080_EmploymentContract.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        //Construtor Padrão
        public HourContract()
        {
        }
        //Contrutor Com todos os Argumentos

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
