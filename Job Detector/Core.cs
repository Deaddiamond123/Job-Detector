using BrokeProtocol.API;
using System;
using System.Collections.Generic;
using System.Text;
using BrokeProtocol.Managers;


namespace Job_Detector
{
    public class Core : Plugin
    {
        public static Core Instance { get; internal set; }
        
        public SvManager Svmanager { get; set; }

        public Core()
        {
            Instance = this;
            Info = new PluginInfo("Job_Detector", "jd");

        }
    }
}
