using System;
using CommsDemo.Settings;
using CommsDemo.Data;

namespace CommsDemo.Model.Audio
{
    public class AudioService : IAudioService, IDisposable
    {
        private readonly ISoundPlayerWrapper _player;
        private AudioConfig _config;
        private string _mediaFile;

        public  AudioService(IConfiguration config, ISoundPlayerWrapper player)
        {
            _config = config.GetConfig<AudioConfig>();
            _mediaFile = "Dummy.wav";
            _player = player;
        }

        public void PlayBeep()
        {
            if (_player.PlayShort(_mediaFile))
            {

            }
        }

        public void PlayContinous()
        {
            if (_player.PlayLong(_mediaFile))
            {

            }
        }

        public void StopPlay()
        {
            if (_player.StopPlay())
            {

            }
        }

        #region IDisposable Support
        private bool _disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (_disposedValue) return;
            if (disposing)
            {
                // TODO: dispose managed state (managed objects).
                _player.StopPlay();
            }

            // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
            // TODO: set large fields to null.

            _player.Dispose();

            _disposedValue = true;
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~MediaService() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
