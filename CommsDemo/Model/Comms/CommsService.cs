using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fpa.Comms;
using Fpa.Comms.Messages;
using System.Threading.Tasks;
using CommsDemo.Settings;
using CommsDemo.Data;

namespace CommsDemo.Model.Comms
{
    public class CommsService : ICommsService
    {
        private CommsConfig _config;
        private SerialCommsInterface _serialInterface;

        public CommsService(IConfiguration config)
        {
            _config = config.GetConfig<CommsConfig>();
        }
    }
}
