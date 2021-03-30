using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HomeTask2.Common
{
    public static class FormCentre
    {
        public static void CentreForm(Window _window)
        {

        double screenHeight = SystemParameters.FullPrimaryScreenHeight;
        double screenWidth = SystemParameters.FullPrimaryScreenWidth;
        _window.Top = (screenHeight - _window.ActualHeight) / 2;
        _window.Left = (screenWidth - _window.ActualWidth) / 2;
        }


    }
}
