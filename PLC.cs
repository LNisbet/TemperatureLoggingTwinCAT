using System;
using TwinCAT.Ads;

namespace TemperatureLogging
{
    public class PLC
    {
        private AdsClient _tcAds = new AdsClient();
        public AdsClient TcAds
        {
            get { return _tcAds; }
            set { _tcAds = value; }
        }
        private AdsState _adsState;
        public AdsState AdsState
        {
            get { return _adsState; }
            set { _adsState = value; }
        }
        public PLC(string ID, int PORT)
        {
            TcAds.Connect(ID, PORT);
        }
        public bool checkConnection()
        {
            return TcAds.IsConnected;
        }
        public AdsState checkAdsState()
        {
            try
            {
                //Could check Run/Stop/Invalid status of this
                AdsState = TcAds.ReadState().AdsState;
                return AdsState;
            }
            catch
            {
                return AdsState.Invalid;
            }
        }
        public AdsState setupPLC()
        {
            if (checkConnection())
            { Console.WriteLine("Port open"); };

            return checkAdsState();
        }
    }
}
