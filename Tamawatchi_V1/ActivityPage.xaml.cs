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
using Windows.UI.Xaml.Media.Imaging;
using System.Drawing;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Tamawatchi_V1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ActivityPage : Page
    {
        public static Pet currentPet = new Pet(1, "default", 100.0, 0.0, "ms-appx://Assets/PetImages/default.png");

        DispatcherTimer timer;
        DispatcherTimer timer2;
        int count = 0;
        int count2 = 0;
        int counter = 600;
        int counter2 = 300;
        int select = 0;


        //public ActivityPage()
        //{
        //    this.InitializeComponent();

        //    this.NavigationCacheMode = NavigationCacheMode.Required;
        //    timer = new DispatcherTimer();
        //    timer.Interval = new TimeSpan(0, 0, 1);
        //    timer.Tick += timer_Tick;

        //    timer2 = new DispatcherTimer();
        //    timer2.Interval = new TimeSpan(0, 0, 1);
        //    timer2.Tick += timer2_Tick;
        //}

        //public ActivityPage(Pet p)
        //{
        //    this.InitializeComponent();

        //    this.NavigationCacheMode = NavigationCacheMode.Required;
        //    timer = new DispatcherTimer();
        //    timer.Interval = new TimeSpan(0, 0, 1);
        //    timer.Tick += timer_Tick;

        //    timer2 = new DispatcherTimer();
        //    timer2.Interval = new TimeSpan(0, 0, 1);
        //    timer2.Tick += timer2_Tick;
        //    SetPet(p);
        //}

        //public void SetPet(Pet p)
        //{
        //    currentPet = p;
        //    Uri imgUri = new Uri(p.GetPath());
        //    BitmapImage img = new BitmapImage(imgUri);
        //    this.petImage.Source = img;

        //}
        private String formatMilliSecondsToTime(long milliseconds)
        {

            int seconds = (int)(milliseconds) % 60;
            int minutes = (int)((milliseconds / 60) % 60);
            return twoDigitString(minutes) + " : "
                    + twoDigitString(seconds);
        }

        private String twoDigitString(long number)
        {

            if (number == 0)
            {
                return "00";
            }

            if (number / 10 == 0)
            {
                return "0" + number;
            }

            return number.ToString();
        }
        void timer_Tick(object sender, object e)
        {

            if (select == 2)
            {
                counter = counter - 1;
                txt.Text = formatMilliSecondsToTime(counter);
                if (counter == 0)
                {
                    timer.Stop();
                    counter = 600;
                }
            }

        }

        void timer2_Tick(object sender, object e)
        {
            if (select == 1)
            {
                counter2 = counter2 - 1;
                timerlog.Text = formatMilliSecondsToTime(counter2);
                if (counter2 == 0)
                {
                    timer2.Stop();
                    counter2 = 300;
                }
            }
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (sender.Equals(TenMinuteWalk))
            {
                select = 2;
                TenMinuteWalk.Background = new SolidColorBrush(Windows.UI.Colors.LightGreen);
                button.Background = new SolidColorBrush(Windows.UI.Colors.LimeGreen);
            }


            if (sender.Equals(FiveMinuteStretch))
            {
                select = 1;
                FiveMinuteStretch.Background = new SolidColorBrush(Windows.UI.Colors.LightGreen);
                button.Background = new SolidColorBrush(Windows.UI.Colors.LimeGreen);

            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {

            if (select == 1)
            {
                FiveMinuteStretch.Background = new SolidColorBrush(Windows.UI.Colors.White);

                if (count2 % 2 == 0)
                {

                    timerlog.Text = formatMilliSecondsToTime(counter2);
                    timer2.Start();
                    count2++;
                    button.Content = "Pause";
                }
                else
                {

                    button.Content = "Start";
                    timer2.Stop();
                    count2++;
                }
            }
            if (select == 2)
            {
                TenMinuteWalk.Background = new SolidColorBrush(Windows.UI.Colors.White);

                if (count % 2 == 0)
                {
                    txt.Text = formatMilliSecondsToTime(counter);
                    timer.Start();
                    count++;
                    button.Content = "Pause";
                }
                else
                {
                    button.Content = "Start";
                    timer.Stop();
                    count++;
                }
            }
        }


    }
}