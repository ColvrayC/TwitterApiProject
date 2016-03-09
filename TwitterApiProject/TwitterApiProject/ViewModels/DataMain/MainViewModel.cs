using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Tweetinvi;
using Tweetinvi.Core.Credentials;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using TwitterApiProject.Helpers;

namespace TwitterApiProject.ViewModels.DataMain
{
    public partial class MainViewModel:ViewModelBase
    {
        //ConnectionProvider cnn = new ConnectionProvider();
        /// <summary>
        ///COMMAND
        /// </summary>
        /// 




        // ConnectionProvider Cnn = new ConnectionProvider() ;
        /// <summary>
        ///CONSTRUCTEUR
        /// </summary>
        public MainViewModel()
        {
            //CurrentView = "LoginView.xaml";
        }
        /// <summary>
        /// PROPERTY
        /// </summary>
        /// 
        /*private string _CurrentView;
        public string CurrentView
        {
            get { return _CurrentView; }
            set { _CurrentView = value; RaisePropertyChanged("CurrentView"); }
        }*/
        
        //public virtual string PathCurrentFrame { get; set; }



        // Please implement this method in a partial class in order to provide the error message depending on each of the properties.
        /// <summary>
        /// METHODES
        /// </summary>
  



        /// <summary>
        /// ERROR 
        /// </summary>
        private string error = string.Empty;
        public string Error { get { return this.error; } }
        public string this[string propertyName]
        {
            get
            {
                this.ValidatePropertyInternal(propertyName, ref this.error);
                return this.error;
            }
        }
        protected virtual void ValidatePropertyInternal(string propertyName, ref string error)
        {
            this.ValidateProperty(propertyName, ref error);
        }

    }

}

