using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;

namespace CommsDemo.Model.Audio
{
    public class SoundPlayerWrapper : ISoundPlayerWrapper
    {
        private readonly SoundPlayer _player;
        public SoundPlayerWrapper()
        {
            _player = new SoundPlayer();
        }

        public bool PlayShort(string mediaFile)
        {
            if (_player == null)
            {
                return false;
            }
            _player.SoundLocation = mediaFile;
            _player.Load();
            _player.Play();
            return true;
        }

        public bool PlayLong(string mediaFile)
        {
            if (_player == null)
            {
                return false;
            }
            return true;
        }

        public bool StopPlay()
        {
            if (_player == null)
            {
                return false;
            }
            _player.Stop();
            return true;
        }

        public bool Dispose()
        {
            if (_player == null)
            {
                return false;
            }
            return true;
        }
    }
}
