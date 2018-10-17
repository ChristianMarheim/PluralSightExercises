using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Counter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private String Text = "0";
        private int counter = 0;

        public MainPage()
        {
            this.InitializeComponent();
            Size size = new Size {Height = 1, Width = 1};

            ApplicationView.GetForCurrentView().SetPreferredMinSize(size);
            ApplicationView.PreferredLaunchViewSize = size;
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            counter++;
            Text = "" + counter;
            _text.Text = Text;
        }

        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            counter = 0;
            Text = "" + counter;
            _text.Text = Text;
        }

        private void MainPage_OnKeyUp(Object sender, KeyRoutedEventArgs e)
        {
            counter++;
            Text = "" + counter;
            _text.Text = Text;
        }
    }
}
