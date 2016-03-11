using Template10.Mvvm;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;
using TwitterProjectClient.Helpers;
using Tweetinvi.Core.Credentials;
using Tweetinvi;
using GalaSoft.MvvmLight.Command;
using Tweetinvi.Core.Parameters;

namespace TwitterProjectClient.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        TwitterCredentials appCredentials;
        public RelayCommand SendPinCodeCommand { get; set; }


        public MainPageViewModel()
        {
            SendPinCodeCommand = new RelayCommand(SendPinCode);
            // Create a new set of credentials for the application
            appCredentials = new TwitterCredentials(Consumer.Key, Consumer.Secret);

            // Go to the URL so that Twitter authenticates the user and gives him a PIN code
            UrlAuth = CredentialsCreator.GetAuthorizationURL(appCredentials);

            
            // UrlAuth  With this pin code it is now possible to get the credentials back from Twitter
            /* var userCredentials = CredentialsCreator.GetCredentialsFromVerifierCode(pinCode, appCredentials);

             // Use the user credentials in your application
             Auth.SetCredentials(userCredentials);*/

        }

        public void SendPinCode()
        {
            var userCredentials = CredentialsCreator.GetCredentialsFromVerifierCode(_PinCode, appCredentials);
            Auth.SetCredentials(userCredentials);
            if(Auth.Credentials != null) //Si erreur sa renvoie null
            {
                GoToTimeLinePage();
               
            }
        }

        //URL d'autorisation
        string _PinCode;
        public string PinCode { get { return _PinCode; } set { Set(ref _PinCode, value); } }

        //URL d'autorisation
        string _UrlAuth;
        public string UrlAuth { get { return _UrlAuth; } set { Set(ref _UrlAuth, value); } }


        string _Value = "Gas";
        public string Value { get { return _Value; } set { Set(ref _Value, value); } }


        /// <summary>
        /// NAVIGATION
        /// </summary>
        /// <param name="parameter"></param>
        /// <param name="mode"></param>
        /// <param name="suspensionState"></param>
        /// <returns></returns>
        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> suspensionState)
        {
            if (suspensionState.Any())
            {
                Value = suspensionState[nameof(Value)]?.ToString();
            }
            await Task.CompletedTask;
        }

        public override async Task OnNavigatedFromAsync(IDictionary<string, object> suspensionState, bool suspending)
        {
            if (suspending)
            {
                suspensionState[nameof(Value)] = Value;
            }
            await Task.CompletedTask;
        }

        public override async Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            args.Cancel = false;
            await Task.CompletedTask;
        }

        public void GoToTimeLinePage() =>
            NavigationService.Navigate(typeof(Views.TimeLinePage), Value);

        public void GotoDetailsPage() =>
            NavigationService.Navigate(typeof(Views.DetailPage), Value);

        public void GotoSettings() =>
            NavigationService.Navigate(typeof(Views.SettingsPage), 0);

        public void GotoPrivacy() =>
            NavigationService.Navigate(typeof(Views.SettingsPage), 1);

        public void GotoAbout() =>
            NavigationService.Navigate(typeof(Views.SettingsPage), 2);

    }
}

