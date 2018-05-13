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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Mediator_buttons
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Mediator.GetInstance().OutputData += OnPrintData;
            InputData += Mediator.GetInstance().OnInputData;

        }
        public event EventHandler<PrintDataEventArgs> InputData;


        public void OnPrintData(object sender, PrintDataEventArgs e)
        {
            _textBlock.Text = e.Data;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InputData.Invoke(sender, new PrintDataEventArgs { Data = ((Button)sender).Content.ToString() });
        }
    }
}
