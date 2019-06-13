using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommsDemo.Model.Audio
{
    public interface ISoundPlayerWrapper
    {
        bool PlayShort(string mediaFile);

        bool PlayLong(string mediaFile);

        bool StopPlay();

        bool Dispose();
    }
}
