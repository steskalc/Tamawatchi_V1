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

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FoodPage : Page
    {
        public static Pet currentPet = new Pet(1, "default", 100.0, 0.0, "ms-appx://Assets/PetImages/default.png");
        int progBar = 0;

        public FoodPage()
        {
            this.InitializeComponent();
            
        }
        public FoodPage(Pet p)
        {
            this.InitializeComponent();
            SetPet(p);
        }

        public void SetPet(Pet p)
        {
            currentPet = p;
            Uri imgUri = new Uri(p.GetPath());
            BitmapImage img = new BitmapImage(imgUri);
            this.petImage.Source = img;

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
    }
}
