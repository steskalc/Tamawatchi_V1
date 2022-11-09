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
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Tamawatchi_V1
{
    /*A simple program loosely based on tamagotchi's pet care aspect.
     Feed pets to track your calorie intake (if you ate chicken, feed the pet chicken)
    Start activities to meet your personal activity goals (basic timer for stretch or walk)
    Mark goals as completed to increase pet happiness.
    */
    public sealed partial class MainPage : Page
    {
         public static Pet currentPet = new Pet(1, "default", 100.0, 0.0, "ms-appx:///Assets/PetImages/pet0.png");
        int progBar = 0;
        string currentGrid = "";
        public MainPage()
        {

            this.InitializeComponent();

            //PetPage p = new PetPage(currentPet);
            //FoodPage f = new FoodPage(currentPet);
            //Activi

            Uri imgUri = new Uri(currentPet.GetPath());
            BitmapImage img = new BitmapImage(imgUri);
            this.petImage.Source = img;
            currentGrid = petGrid.Name.ToString();

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += timer_Tick;

            timer2 = new DispatcherTimer();
            timer2.Interval = new TimeSpan(0, 0, 1);
            timer2.Tick += timer2_Tick;

        }

        public void SetPet(Pet p)
        {
            currentPet = p;
            Uri imgUri = new Uri(p.GetPath());
            BitmapImage img = new BitmapImage(imgUri);
            this.petImage.Source = img;

        }

        public void changePet(object sender, RoutedEventArgs e)
        {
            string path = "";

            if (sender.Equals(pet0))
            {
                path = currentPet.ChangeImage(0);
            }

            if (sender.Equals(pet1))
            {
            
                path = currentPet.ChangeImage(1);
            }

            if (sender.Equals(pet2))
            {
                path = currentPet.ChangeImage(2);
            }

            if (sender.Equals(pet3))
            {
                path = currentPet.ChangeImage(3);
            }

            if (path != "")
            {
                var imgUri = new Uri(path);

                BitmapImage img = new BitmapImage(imgUri);
                petImage.Source = img;
            }

        }

        private void menuButton_Click(object sender, RoutedEventArgs e)
        {
            //add cases for each button on menu

            if (sender.Equals(foodButton))
            {
                if (currentGrid.Equals("petGrid"))
                {
                    petGrid.Visibility = Visibility.Collapsed;
                }
                else if (currentGrid.Equals("goalsGrid"))
                {
                    goalsGrid.Visibility = Visibility.Collapsed;
                }
               else
                {
                    activityGrid.Visibility = Visibility.Collapsed;
                }

                foodGrid.Visibility = Visibility.Visible;
                currentGrid = "foodGrid";
            }

            else if (sender.Equals(petButton))
            {
    
                if (currentGrid.Equals("foodGrid"))
                {
                    foodGrid.Visibility = Visibility.Collapsed;
                }

                else if (currentGrid.Equals("goalsGrid"))
                {
                    goalsGrid.Visibility = Visibility.Collapsed;
                }
                else
                {
                    activityGrid.Visibility = Visibility.Collapsed;
                }

                petGrid.Visibility = Visibility.Visible;
                currentGrid = "petGrid";

            }

            else if (sender.Equals(goalsButton))
            {
                if (currentGrid.Equals("foodGrid"))
                {
                    foodGrid.Visibility = Visibility.Collapsed;
                }

                else if (currentGrid.Equals("petGrid"))
                {
                    petGrid.Visibility = Visibility.Collapsed;
                }
                else
                {
                    activityGrid.Visibility = Visibility.Collapsed;
                }

                goalsGrid.Visibility = Visibility.Visible;
                currentGrid = "goalsGrid";

            }

            else//activity button
            {
                if (currentGrid.Equals("foodGrid"))
                {
                    foodGrid.Visibility = Visibility.Collapsed;
                }

                else if (currentGrid.Equals("goalsGrid"))
                {
                    goalsGrid.Visibility = Visibility.Collapsed;
                }
                else
                {
                    petGrid.Visibility = Visibility.Collapsed;
                }

                activityGrid.Visibility = Visibility.Visible;
                currentGrid = "activityGrid";

            }



        }

        public async void Button_Click(object sender, RoutedEventArgs e)
        {

            if (sender.Equals(addOne))
            {
                int increment = Convert.ToInt32(servingsOne.Text);
                servingsOne.Text = $"{increment + 1}";
                int addTotal = Convert.ToInt32(totalCalories.Text);
                totalCalories.Text = $"{addTotal + 165}";
                progBar += 165;

            }
            if (sender.Equals(removeOne))
            {
                int decrement = Convert.ToInt32(servingsOne.Text);
                servingsOne.Text = $"{decrement - 1}";
                int removeTotal = Convert.ToInt32(totalCalories.Text);
                totalCalories.Text = $"{removeTotal - 165}";

            }

            if (sender.Equals(addTwo))
            {
                int increment = Convert.ToInt32(servingsTwo.Text);
                servingsTwo.Text = $"{increment + 1}";
                int addTotal = Convert.ToInt32(totalCalories.Text);
                totalCalories.Text = $"{addTotal + 210}";
                progBar += 210;
            }
            if (sender.Equals(removeTwo))
            {
                int decrement = Convert.ToInt32(servingsTwo.Text);
                servingsTwo.Text = $"{decrement - 1}";
                int removeTotal = Convert.ToInt32(totalCalories.Text);
                totalCalories.Text = $"{removeTotal - 210}";


            }

            if (sender.Equals(addThree))
            {
                int increment = Convert.ToInt32(servingsThree.Text);
                servingsThree.Text = $"{increment + 1}";
                int addTotal = Convert.ToInt32(totalCalories.Text);
                totalCalories.Text = $"{addTotal + 71}";
                progBar += 71;
            }
            if (sender.Equals(removeThree))
            {
                int decrement = Convert.ToInt32(servingsThree.Text);
                servingsThree.Text = $"{decrement - 1}";
                int removeTotal = Convert.ToInt32(totalCalories.Text);
                totalCalories.Text = $"{removeTotal - 71}";

            }

            if (sender.Equals(feedPet))
            {
                // Would probably update progress bar here?
                hungerBar.Value += progBar;
                totalCalories.Text = $"{"0"}";
                servingsOne.Text = $"{"0"}";
                servingsTwo.Text = $"{"0"}";
                servingsThree.Text = $"{"0"}";
                progBar = 0;
            }
        }

        private int ConvertToInt32(string text)
        {
            throw new NotImplementedException();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        //goals

        private void IncreaseHappy()
        {
            happBar.Value += 200;
        }

        private void DecreaseHappy()
        {
            happBar.Value -= 200;
        }

        private void Click_Goal1(object sender, RoutedEventArgs e)
        {
            //Detect the current image
            var filled_loc = new Uri("ms-appx:///Assets/Items/Star_Fill.png");
            var empty_loc = new Uri("ms-appx:///Assets/Items/Star_Empty.png");
            if (star1.Source.GetType() == typeof(BitmapImage) && (star1.Source as BitmapImage).UriSource.Equals(empty_loc))
            {
                BitmapImage filled = new BitmapImage(filled_loc);
                star1.Source = filled;
                IncreaseHappy();
            }
            else
            {
                BitmapImage empty = new BitmapImage(empty_loc);
                star1.Source = empty;
                DecreaseHappy();
            }

            
        }
        private void Click_Goal2(object sender, RoutedEventArgs e)
        {
            //Detect the current image
            var filled_loc = new Uri("ms-appx:///Assets/Items/Star_Fill.png");
            var empty_loc = new Uri("ms-appx:///Assets/Items/Star_Empty.png");
            if (star2.Source.GetType() == typeof(BitmapImage) && (star2.Source as BitmapImage).UriSource.Equals(empty_loc))
            {
                BitmapImage filled = new BitmapImage(filled_loc);
                star2.Source = filled;
                IncreaseHappy();
            }
            else
            {
                BitmapImage empty = new BitmapImage(empty_loc);
                star2.Source = empty;
                DecreaseHappy();
            }
        }

        private void Click_Goal3(object sender, RoutedEventArgs e)
        {
            //Detect the current image
            var filled_loc = new Uri("ms-appx:///Assets/Items/Star_Fill.png");
            var empty_loc = new Uri("ms-appx:///Assets/Items/Star_Empty.png");
            if (star3.Source.GetType() == typeof(BitmapImage) && (star3.Source as BitmapImage).UriSource.Equals(empty_loc))
            {
                BitmapImage filled = new BitmapImage(filled_loc);
                star3.Source = filled;
                IncreaseHappy();
            }
            else
            {
                BitmapImage empty = new BitmapImage(empty_loc);
                star3.Source = empty;
                DecreaseHappy();
            }
        }

        private void Click_Goal4(object sender, RoutedEventArgs e)
        {
            //Detect the current image
            var filled_loc = new Uri("ms-appx:///Assets/Items/Star_Fill.png");
            var empty_loc = new Uri("ms-appx:///Assets/Items/Star_Empty.png");
            if (star4.Source.GetType() == typeof(BitmapImage) && (star4.Source as BitmapImage).UriSource.Equals(empty_loc))
            {
                BitmapImage filled = new BitmapImage(filled_loc);
                star4.Source = filled;
                IncreaseHappy();
            }
            else
            {
                BitmapImage empty = new BitmapImage(empty_loc);
                star4.Source = empty;
                DecreaseHappy();
            }
        }
        private void Click_Goal5(object sender, RoutedEventArgs e)
        {
            //Detect the current image
            var filled_loc = new Uri("ms-appx:///Assets/Items/Star_Fill.png");
            var empty_loc = new Uri("ms-appx:///Assets/Items/Star_Empty.png");
            if (star5.Source.GetType() == typeof(BitmapImage) && (star5.Source as BitmapImage).UriSource.Equals(empty_loc))
            {
                BitmapImage filled = new BitmapImage(filled_loc);
                star5.Source = filled;
                IncreaseHappy();
            }
            else
            {
                BitmapImage empty = new BitmapImage(empty_loc);
                star5.Source = empty;
                DecreaseHappy();
            }
        }

        //activity

        DispatcherTimer timer;
        DispatcherTimer timer2;
        int count = 0;
        int count2 = 0;
        int counter = 600;
        int counter2 = 300;
        int select = 0;
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

        private void activityButtonClick(object sender, RoutedEventArgs e)
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
