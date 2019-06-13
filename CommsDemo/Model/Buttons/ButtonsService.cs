using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommsDemo.Settings;
using CommsDemo.Data;

namespace CommsDemo.Model.Buttons
{
    public class ButtonsService : IButtonsService
    {
        private ButtonConfig _config;
        public ButtonsService(IConfiguration config)
        {
            _config = config.GetConfig<ButtonConfig>();
        }
    }
}
