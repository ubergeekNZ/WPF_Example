using System;
using GalaSoft.MvvmLight;
using CommsDemo.Helpers;
using CommsDemo.Model.Display;
using CommsDemo.Model.Buttons;
using static System.String;
using log4net;

namespace CommsDemo.ViewModel
{
    public class DisplayViewModel : ViewModelBase, IMouseCaptureProxy
    {
        private readonly IDisplayService _displayService;
        private readonly IButtonsService _buttonsService;

        public event EventHandler Capture;
        public event EventHandler Release;

        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public DisplayViewModel(IDisplayService displayService, IButtonsService buttonsService)
        {
            Log.Debug("Loading Display View Model");

            _displayService = displayService;
            _buttonsService = buttonsService;

            // need to create a mouse coordinate converter and pass commands to display service
            
            //_displayService = displayService;

            //_displayService.RegisterDisplayCallback(DisplayCallback);

            //var displayInfo = _displayService.GetCurrentValues();

            //DisplayCallback(displayInfo);
        }


        public void OnMouseDown(object sender, MouseCaptureArgs e)
        {

        }

        public void OnMouseMove(object sender, MouseCaptureArgs e)
        {
            // Do nothing
        }

        public void OnMouseUp(object sender, MouseCaptureArgs e)
        {
            // Do nothing
        }

        //public string UpperCelsiusPath { get; set; }
        //public string UpperFahrenheitPath { get; set; }
        //public string LowerCelsiusPath { get; set; }
        //public string LowerFahrenheitPath { get; set; }
        //public string UpperMinusSignPath { get; set; }
        //public string LowerMinusSignPath { get; set; }
        //public string UpperCompartmentPath { get; set; }
        //public string LowerCompartmentPath { get; set; }
        //public string WineLedPath { get; set; }
        //public string PantryLedPath { get; set; }
        //public string FridgeLedPath { get; set; }
        //public string ChillLedPath { get; set; }
        //public string WifiLedPath { get; set; }
        //public string ErrorLedPath { get; set; }
        //public string ShabatLedPath { get; set; }
        //public string ServiceLedPath { get; set; }
        //public string LockLedPath { get; set; }
        //public string HumidityMinPath { get; set; }
        //public string HumidityMaxPath { get; set; }
        //public string HumidityOnPath { get; set; }
        //public string AlarmMutePath { get; set; }
        //public string UpperFirstPath { get; set; }
        //public string UpperSecondPath { get; set; }
        //public string UpperThirdPath { get; set; }
        //public string LowerFirstPath { get; set; }
        //public string LowerSecondPath { get; set; }
        //public string LowerThirdPath { get; set; }
        //public string UpperDecimalPath { get; set; }
        //public string LowerDecimalPath { get; set; }

        protected virtual void OnCapture()
        {
            Capture?.Invoke(this, EventArgs.Empty);
        }
    }
}
