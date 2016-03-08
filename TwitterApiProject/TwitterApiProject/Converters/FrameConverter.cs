using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterApiProject.Converters
{
    public class FrameConverter
    {
        //Path View
        const string Login = "LoginView.xaml";
        const string TimeLine = "TimeLineView.xaml";
        const string Tweet = "TweetView.xaml";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string Result = "";
            switch (value.ToString())
            {
                //Compta Matière
                case Login:
                    Result = Login;
                    break;
                case TimeLine:
                    Result = TimeLine;
                    break;
                case Tweet:
                    Result = Tweet;
                    break;
            }
            return Result;
        }

    }
}
