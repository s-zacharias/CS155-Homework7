using System;
namespace Project1
{
    public class Odometer
    {
        // Instance Variables
        int miles;
        double fuelUsed; 

       // Contructors
       public Odometer() // default constructor
        {
            miles = 0;
            fuelUsed = 15;
        }
        public Odometer(int miles, double fuelUsed) // fully loaded constructor
        {
            this.miles = miles;
            this.fuelUsed = fuelUsed;
        }
       // Methods

       public void setMiles(int m)
        {
            miles = m;
        }

       public int getMiles()
        {
            return miles;
        }

        public void setFuelUsed(double f)
        {
            fuelUsed = f;
        }

        public double getFuelUsed()
        {
            return fuelUsed;
        }

       public void reset()
        {
            miles = 0;
            fuelUsed = 0;
        }

       public void Add(int m, double f)
        {
            miles += m;
            fuelUsed += f;
        }

        public double mpg()
        {
            return (miles / fuelUsed);
        }

        public string toString()
        {
            return miles + " Miles Driven " + fuelUsed + " Fuel Used";
        }

        public bool equals(Odometer other)
        {
            return (this.getMiles() == other.getMiles()) && (this.getFuelUsed() == other.getFuelUsed());
            // return (this.miles == other.miles) && (this.fuelUsed == other.fuelUsed);
        }
    }
}
