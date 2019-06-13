using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Components.DictionaryAdapter;
using System.Threading.Tasks;

namespace CommsDemo.Settings
{
    public interface IConfiguration
    {
        T GetConfig<T>();
    }
}
