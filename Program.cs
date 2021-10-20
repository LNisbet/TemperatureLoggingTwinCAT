using System;

namespace TemperatureLogging
{
    class Program
    {
        static int NumberOfSensors;
        static void Main()
        {
            ReadNumberOfSensors();
            WriteData(ReadSensors());
        }

        static void ReadNumberOfSensors()
        {
            Console.WriteLine("Number of Sensors?");
            var input = Console.ReadLine();
            if (int.TryParse(input, out NumberOfSensors))
            {
                return;
            }
            else
            {
                Console.WriteLine($"{input} is not a number");
            }

        }

        static string[] ReadSensors()
        {
            string[] SensorData = new string[NumberOfSensors];

            for (int i = 0; i < SensorData.Length; i++)
            {
                Console.WriteLine("Value" +(i+1));
                SensorData[i] = Console.ReadLine();
            }
            return SensorData;
        }

        static void WriteData(String[] Data)
        {
            for (int i = 0; i < Data.Length; i++)
            {
                Console.WriteLine("Data" + (i+1) + " " + Data[i]);
            }
            return;
        }
    }
}
