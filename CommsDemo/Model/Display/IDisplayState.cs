using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommsDemo.Data;

namespace CommsDemo.Model.Display
{
    public interface IDisplayState
    {
        void ProcessCmdKeys(Cmdkeys keys);

        void SetContext(IDisplayService context);
    }
}
