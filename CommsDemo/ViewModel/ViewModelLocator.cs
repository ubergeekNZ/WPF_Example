/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:CommsDemo"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using CommsDemo.Model.Audio;
using CommsDemo.Model.Comms;
using CommsDemo.Model.Display;
using CommsDemo.Model.Buttons;
using CommsDemo.Settings;

namespace CommsDemo.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            IConfiguration config = new Configuration("config.json");
            ICommsService commsService = new CommsService(config);
            ISoundPlayerWrapper player = new SoundPlayerWrapper();

            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register(() => { return new ButtonsService(config); });
            SimpleIoc.Default.Register<IButtonsService>(() => {
                return SimpleIoc.Default.GetInstance<ButtonsService>();
            });


            SimpleIoc.Default.Register(() => { return new AudioService(config, player);});
            SimpleIoc.Default.Register<IAudioService>(() => {
                return SimpleIoc.Default.GetInstance<AudioService>();
            });

            SimpleIoc.Default.Register(() => { return new DisplayService(config, new InactiveState(), commsService);});
            SimpleIoc.Default.Register<IDisplayService>(() => {
                return SimpleIoc.Default.GetInstance<DisplayService>();
            });

            SimpleIoc.Default.Register<DisplayViewModel>();
        }

        public DisplayViewModel Main => ServiceLocator.Current.GetInstance<DisplayViewModel>();

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}