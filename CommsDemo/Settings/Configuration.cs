using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Reflection;
using CommsDemo.Data;

namespace CommsDemo.Settings
{
    public class Configuration : IConfiguration
    {
        private ConfigData _configData;
        public Configuration(string configFile)
        {
            var json = File.ReadAllText(configFile);

            var messages = new List<string>();

            var settings = new JsonSerializerSettings()
            {
                Error = (s, e) => {
                    var depObj = e.CurrentObject as ConfigData;
                    if (depObj != null)
                    {
                        messages.Add(string.Format("Obj:{0} Message:{1}", depObj, e.ErrorContext.Error.Message));
                    }
                    else
                    {
                        messages.Add(e.ErrorContext.Error.Message);
                    }
                    e.ErrorContext.Handled = true; // Set the datetime to a default value if not Nullable
                }
            };
            // Add error checking
            _configData = JsonConvert.DeserializeObject<ConfigData>(json, settings);
        }

        public T GetConfig<T>()
        {
            T temp;
            temp = default(T);

            PropertyInfo[] properties = _configData.GetType().GetProperties();
            foreach (var p in properties)
            {
                if (typeof(T) == p.PropertyType)
                {
                    temp = (T)p.GetValue(_configData, null);
                }
            }

            return temp;
        }
    }
}
