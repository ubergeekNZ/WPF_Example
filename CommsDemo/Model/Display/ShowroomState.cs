using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommsDemo.Data;

namespace CommsDemo.Model.Display
{
    public class ShowroomState : IDisplayState
    {
        private IDisplayService _context;
        public void ProcessCmdKeys(Cmdkeys keys)
        {
            throw new NotImplementedException();
        }

        public void SetContext(IDisplayService context)
        {
            _context = context;
        }
    }
}
