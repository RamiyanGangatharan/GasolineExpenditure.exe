using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasolineExpenditure
{
    internal class Gasoline
    {
        // This class is planned to be for gasoline objects (getters, setters, and constructors)

        public int Invoice { get; set; }
        public DateTime Date { get; set; }
        public string FullName { get; set; }
        public string Company { get; set; }
        public string Station { get; set; }
        public int PumpNumber { get; set; }
        public string Octane { get; set; }
        public decimal Litres { get; set; }
        public decimal LitresPerDollar { get; set; }
        public int TotalPoints { get; set; }
        public int PointsGained { get; set; }
        public decimal Taxes { get; set; }

        public Gasoline()
        {
            // Initialize properties with default values if needed
            Invoice = 0;
            Date = DateTime.MinValue;
            FullName = "";
            Company = "";
            Station = "";
            PumpNumber = 0;
            Octane = "";
            Litres = 0.0m;
            LitresPerDollar = 0.0m;
            TotalPoints = 0;
            PointsGained = 0;
            Taxes = 0.0m;
        }

        // Parameterized constructor
        public Gasoline
          (
            int invoice, DateTime date, string fullName, string company, string station, int pumpNumber, string octane,
            decimal litres, decimal litresPerDollar, int totalPoints, int pointsGained, decimal taxes
          ) : this() // Call the default constructor to initialize all properties
        {
            Invoice = invoice;
            Date = date;
            FullName = fullName;
            Company = company;
            Station = station;
            PumpNumber = pumpNumber;
            Octane = octane;
            Litres = litres;
            LitresPerDollar = litresPerDollar;
            TotalPoints = totalPoints;
            PointsGained = pointsGained;
            Taxes = taxes;
        }
    }
}