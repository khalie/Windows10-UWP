using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=234238 dokumentiert.

namespace UWP_031
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class CoffeePage : Page
    {
        String order = "None";
        String roast = "";
        String sweetener = "";
        String cream = "";

        public CoffeePage()
        {
            this.InitializeComponent();
        }

        private void btnNone_Click(object sender, RoutedEventArgs e)
        {
            order = "None";
            updateOrder();
        }

        private void btnDark_Click(object sender, RoutedEventArgs e)
        {
            roast = "Dark";
            updateOrder();
        }

        private void btnMedium_Click(object sender, RoutedEventArgs e)
        {
            roast = "Medium";
            updateOrder();
        }

        private void updateOrder()
        {
            if (roast != "None")
                order = roast + " " + sweetener + " " + cream;
            else
                order = "None";
        }
    }
}
