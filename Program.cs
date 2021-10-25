using System;
using System.Collections.Generic;

namespace TemperatureLogging
{
    public class Program
    {
        public PLC myPLC { get; set; }


        static int NumberOfSensors;
        public void Main()
        {
            ReadNumberOfSensors();
            List<TempSensor> TempSensors= new List<TempSensor>(NumberOfSensors);

            WriteData(TempSensors);
        }

        static void ReadNumberOfSensors()
        {
            int retries = 3;
            Console.WriteLine("Number of Sensors?");
            var input = Console.ReadLine();
            try 
            {
                int.TryParse(input, out NumberOfSensors);
                return;
            }
            catch
            {
                if (--retries == 0) throw;
                else Console.WriteLine($"{input} is not a number");
            }

        }

        static void WriteData(List<TempSensor> Data)
        {
            for (int i = 0; i < Data.Count; i++)
            {
                Console.WriteLine("Data" + (i+1) + " " + Data[i]);
            }
            return;
        }
    }
}
