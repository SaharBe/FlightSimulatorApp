using System;
using System.Collections.Generic;
using System.Text;

namespace FlightSimulatorApp
{
    interface Iplane
    {
        void connect(string ip, int port);
        void disconnect();
        void start();
        double LeftSonar
        {
            set;
            get;
        }
        double CenterSonar
        {
            set;
            get;
        }

        double RightSonar
        {
            set;
            get;
        }
        byte[][] CamView
        {
            set;
            get;
        }
    }
}
