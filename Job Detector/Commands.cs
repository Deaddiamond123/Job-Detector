using BrokeProtocol.API;
using BrokeProtocol.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Job_Detector
{
    public class Commands : IScript 
    {
        public Commands()
        {
            CommandHandler.RegisterCommand(new List<string> { "jd", "jobdetect" }, new Action<ShPlayer>(OnJobDetection));

        }
        public void OnJobDetection(ShPlayer player)
        {
            var sb = new StringBuilder();
            foreach (var job in BPAPI.Instance.Jobs)
            {
                sb.AppendLine($"There's a total of {job.members.Count()}: {job.shared.jobName}/s connected.");
            }
            player.svPlayer.SendTextMenu($"Jobs", sb.ToString());
        }
    }
}
