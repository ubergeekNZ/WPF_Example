using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommsDemo.Data;
using CommsDemo.Model.Comms;
using CommsDemo.Settings;

namespace CommsDemo.Model.Display
{
    public class DisplayService : IDisplayService
    {
        private IDisplayState _currentState;
        private ICommsService _commsService;
        private DisplayConfig _config;
        public DisplayService(IConfiguration config, IDisplayState initialState, ICommsService commsService)
        {
            _config = config.GetConfig<DisplayConfig>();
            _currentState = initialState;
            _currentState.SetContext(this);
            _commsService = commsService;
        }

        public void SetState(IDisplayState newState)
        {
            _currentState = newState;
            _currentState.SetContext(this);
        }
        public void ProcessKeyCommands(Cmdkeys keys)
        {
            _currentState.ProcessCmdKeys(keys);
        }
    }
}
