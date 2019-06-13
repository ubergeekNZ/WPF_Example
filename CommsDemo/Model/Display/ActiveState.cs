using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommsDemo.Data;

namespace CommsDemo.Model.Display
{
    public class ActiveState : IDisplayState
    {
        private IDisplayService _service;
        public void ProcessCmdKeys(Cmdkeys keys)
        {
            throw new NotImplementedException();
        }

        public void SetContext(IDisplayService context)
        {
            throw new NotImplementedException();
        }

        public void Setservice(IDisplayService service)
        {
            _service = service;
        }
    }
}
