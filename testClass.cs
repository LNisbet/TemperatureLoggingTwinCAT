using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureLogging
{
    class testClass
    {
        public PLC Plc { get; set; }
        public testClass(PLC inputPlc)
        {
            Plc = inputPlc;
        }
        private uint myBoolHandle;

        public void setVariableHandles()
        {
            myBoolHandle = MyPlc.TcAds.CreateVariableHandle("MAIN.myBool");
        }
        public bool getMyBoolVal()
        {
            return (bool)MyPlc.TcAds.ReadAny(myBoolHandle, typeof(bool));
            
        }
    }
}
