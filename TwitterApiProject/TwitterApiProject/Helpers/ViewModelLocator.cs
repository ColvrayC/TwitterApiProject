using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using System;
using TwitterApiProject.ViewModels.DataLogin;
using TwitterApiProject.ViewModels.DataMain;
using TwitterApiProject.ViewModels.DataTimeLine;
using TwitterApiProject.ViewModels.DataTweet;

namespace TwitterApiProject.Helpers
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<TimeLineViewModel>();
            SimpleIoc.Default.Register<TweetViewModel>();

        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>(Guid.NewGuid().ToString());
            }
        }

        public LoginViewModel Login
        {
            get
            {
                return ServiceLocator.Current.GetInstance<LoginViewModel>();
            }
        }

        public TimeLineViewModel TimeLine
        {
            get
            {
                return ServiceLocator.Current.GetInstance<TimeLineViewModel>();
            }
        }

        public TweetViewModel Tweet
        {
            get
            {
                return ServiceLocator.Current.GetInstance<TweetViewModel>();
            }
        }
    }
}
