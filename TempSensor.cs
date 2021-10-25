using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureLogging
{
    class TempSensor
    {

        public TempSensor(int id)
        {
            ID = id;
        }

        public int ID;
        public string SensorData;

        public void Main()
        {
            ReadSensors();
            WriteData();
        }

        void ReadSensors()
        {

            Console.WriteLine($"Value {ID}");
            SensorData = Console.ReadLine();
           
            return;
        }

        void WriteData()
        {
            Console.WriteLine($"Data{ID} {SensorData}");
            return;
        }
    }
}
