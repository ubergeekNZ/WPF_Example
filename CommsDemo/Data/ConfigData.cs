using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommsDemo.Data
{
    public class ConfigData
    {
        public AudioConfig audioConfig { get; set; }
        public ButtonConfig buttonConfig { get; set; }
        public CommsConfig commsConfig { get; set; }
        public DisplayConfig displayConfig { get; set; }

        public ConfigData()
        {
            //if (this.audioConfig == null)
            //{
            //    this.audioConfig = new AudioConfig() { beepWaveFile = "beep.wav" };
            //}
        }
    }
}
