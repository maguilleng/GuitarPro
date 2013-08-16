using Constructora.Web;
using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Constructora.Infrastructure
{
    public class BoolToLoginImagePathConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var currentUser = value as UserAuth;
            if (currentUser != null && currentUser.IsAuthenticated)
            {
                return "/Constructora.Infrastructure;component/Assets/Images/UserOn.jpg";
            }
            else
            {
                return "/Constructora.Infrastructure;component/Assets/Images/UserOff.jpg";
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
