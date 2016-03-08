using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Tweetinvi;
using Tweetinvi.Core.Credentials;

namespace TwitterApiProject.ViewModels.DataMain
{
    public partial class MainViewModel
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


        }
        /// <summary>
        /// PROPERTY
        /// </summary>
        /// 



        //public virtual string PathCurrentFrame { get; set; }



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

    }

}

