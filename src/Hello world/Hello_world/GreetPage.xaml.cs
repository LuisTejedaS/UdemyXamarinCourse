using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hello_world
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();

            /**
             * 
             * Content = new Lable
             * { 
             *  HorizontalOptions = LayoutOptions.Center,
             *  VerticalOptions = LayoutOptions.Center,
             *  Text = "Hello World"
             * }
             * */

            slider.Value = 0.5;

            //if(Device.OS ==  TargetPlatform.iOS)
            //{
            //    Padding = new Thickness(0,20,0,0);
            //}
            //Device.OnPlatform<Thickness>(
            //    iOS: new Thickness(0, 20, 0, 0),
            //    Android: new Thickness(0, 20, 0, 0),
            //    WinPhone: new Thickness(0, 20, 0, 0));

            //Device.OnPlatform(
            //    iOS: () =>
            //   {
            //       Padding = new Thickness(0, 20, 0, 0);
            //   });

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Title", "Hello World", "OK");
        }

        //private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    label.Text = String.Format("Value is {0:F2}", e.NewValue);
          
        //}
    }
}