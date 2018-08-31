using System;
using Plugin.Connectivity;

namespace Travel.Logic
{
    public class HomeLogic
    {
        public static bool CheckInternetIsAvailable()
        {
            return CrossConnectivity.Current.IsConnected;
        }
    }
}
