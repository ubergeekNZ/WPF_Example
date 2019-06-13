using NUnit.Framework;
using CommsDemo.Model.Audio;
using CommsDemo.Settings;
using Moq;

namespace CommsDemo.Tests
{
    [TestFixture]
    public class AudioServiceTest
    {
        [Test]
        public void TestPlayShort()
        {
            Mock<ISoundPlayerWrapper> mockSoundPlayer = new Mock<ISoundPlayerWrapper>();
            Mock<IConfiguration> mockConfig = new Mock<IConfiguration>();

            AudioService audioService = new AudioService(mockConfig.Object, mockSoundPlayer.Object);

            audioService.PlayBeep();

            mockSoundPlayer.Verify(m => m.PlayShort("Dummy.wav"));
        }

        [Test]
        public void TestPlayLong()
        {
            Mock<ISoundPlayerWrapper> mockSoundPlayer = new Mock<ISoundPlayerWrapper>();
            Mock<IConfiguration> mockConfig = new Mock<IConfiguration>();

            AudioService audioService = new AudioService(mockConfig.Object, mockSoundPlayer.Object);

            audioService.PlayContinous();

            mockSoundPlayer.Verify(m => m.PlayLong("Dummy.wav"));
        }
    }
}