using System;
using System.Collections.Generic;
using System.Text;
using BrokeProtocol.API;
using BrokeProtocol.Managers;

namespace Job_Detector.Events
{
    public class Onstart : IScript
    {
        [Target(GameSourceEvent.ManagerStart, ExecutionMode.Event)]
        public void Onstarted(SvManager Svmanager)
        {
            Core.Instance.Svmanager = Svmanager;
        }            
    }
}
