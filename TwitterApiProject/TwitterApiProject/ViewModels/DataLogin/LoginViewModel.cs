using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterApiProject.ViewModels.DataLogin
{
    public partial class LoginViewModel : ViewModelBase
    {

        //ConnectionProvider cnn = new ConnectionProvider();
        /// <summary>
        ///COMMAND
        /// </summary>
        /// 
        public RelayCommand CreateCustomerCommand { get; set; }
        public RelayCommand<string> OpenFlyOutCommand { get; set; }

        public RelayCommand<string> EditModeCommand { get; set; }


        // ConnectionProvider Cnn = new ConnectionProvider() ;
        /// <summary>
        ///CONSTRUCTEUR
        /// </summary>
        public LoginViewModel()
        {
            //OpenFlyOutCommand = new RelayCommand<string>(ShowFlyOut);
        }
        /// <summary>
        /// PROPERTY
        /// </summary>
        /// 



        public virtual string BindCurrentMode
        {
            get { return BindCurrentMode; }
            set { BindCurrentMode = value; RaisePropertyChanged("BindCurrentMode"); }
        }
       
        public virtual bool OpenFlyOut { get; set; }


        // Please implement this method in a partial class in order to provide the error message depending on each of the properties.
        /// <summary>
        /// METHODES
        /// </summary>
        /// 



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

        //CleanUp
        public override void Cleanup()
        {

            base.Cleanup();
        }
    }
}
