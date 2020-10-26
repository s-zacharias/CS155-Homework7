using System;
namespace Project2
{
    public class Temperature
    {
        // instance variables
        double temperature;
        char scale; // can only accept 'C' or 'F'

        // Constructors
        public Temperature() // default constructor
        {
            temperature = 0;
            scale = 'C';
        }

        public Temperature(double temperature, char scale) // fully loaded constructor
        {
            this.temperature = temperature;
            this.scale = scale;
        }

        // Methods
        public double getFahrenheit()
        {
            double Celcius = ((temperature - 32) * 5) / 9;
            
            if (scale == 'C')
            {
                return Math.Round(Celcius, 1);
            } else // assume scale == 'F'
            {
                return Math.Round(temperature, 1);
            }
        }

        public double getCelcius()
        {
            double Fahrenheit = ((temperature + 32) * 5) / 9;

            if (scale == 'F')
            {
                return Math.Round(Fahrenheit, 1);
            } else // assume scale == 'C'
            {
                return Math.Round(temperature, 1);
            } 
        }

        public void setTemperature(double temp)
        {
            temperature = temp;
        }

        public void setScale(char celFar)
        {
            scale = celFar;
        }

        public void setTemperatureAndScale(double temp, char celFar)
        {
            temperature = temp;
            scale = celFar;
        }

        public String toString()
        {
            return "The temperature is " + temperature + " degrees " + scale;
        }

        public bool Equals(Temperature other)
        {
            return (this.getCelcius() == other.getCelcius()
                && this.getFahrenheit() == other.getFahrenheit());
        }
    }
}
