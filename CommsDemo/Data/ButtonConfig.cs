using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommsDemo.Data
{
    public class ButtonsParams
    {
        public string cmd;
        public int x;
        public int y;
    }
    public class ButtonConfig
    {
        public List<ButtonsParams> buttons;
    }
}
