using Constructora.Web;
using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;


namespace Constructora.Infrastructure
{
    public class CurrentUserToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var currentUser = value as UserAuth;

            if (currentUser != null && currentUser.IsAuthenticated)
            {
                return Visibility.Visible;
            }
            else
            {
                return Visibility.Collapsed;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
