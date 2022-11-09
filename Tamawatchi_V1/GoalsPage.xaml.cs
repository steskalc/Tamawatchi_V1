using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System.Threading;
using Windows.UI.Core;
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
    public sealed partial class GoalsPage : Page
    {
        //public static Pet currentPet = new Pet(1, "default", 100.0, 0.0, "ms-appx://Assets/PetImages/default.png");

        //public GoalsPage()
        //{
        //    //int happBar = 0;
        //    this.InitializeComponent();
        //}

        //public GoalsPage(Pet p)
        //{
        //    this.InitializeComponent();
        //    SetPet(p);
        //}
        //public void SetPet(Pet p)
        //{
        //    currentPet = p;
        //    Uri imgUri = new Uri(p.GetPath());
        //    BitmapImage img = new BitmapImage(imgUri);
        //    this.petImage.Source = img;

        //}
        //private void IncreaseHappy()
        //{
        //    happBar.Value += 200;
        //}

        //private void DecreaseHappy()
        //{
        //    happBar.Value -= 200;
        //}

        //private void Click_Goal1(object sender, RoutedEventArgs e)
        //{
        //    //Detect the current image
        //    var filled_loc = new Uri("ms-appx:///Assets/Items/Star_Fill.png");
        //    var empty_loc = new Uri("ms-appx:///Assets/Items/Star_Empty.png");
        //    if (star1.Source.GetType() == typeof(BitmapImage) && (star1.Source as BitmapImage).UriSource.Equals(empty_loc))
        //    {
        //        BitmapImage filled = new BitmapImage(filled_loc);
        //        star1.Source = filled;
        //        IncreaseHappy();
        //    }
        //    else
        //    {
        //        BitmapImage empty = new BitmapImage(empty_loc);
        //        star1.Source = empty;
        //        DecreaseHappy();
        //    }
        //}
        //private void Click_Goal2(object sender, RoutedEventArgs e)
        //{
        //    //Detect the current image
        //    var filled_loc = new Uri("ms-appx:///Assets/Items/Star_Fill.png");
        //    var empty_loc = new Uri("ms-appx:///Assets/Items/Star_Empty.png");
        //    if (star2.Source.GetType() == typeof(BitmapImage) && (star2.Source as BitmapImage).UriSource.Equals(empty_loc))
        //    {
        //        BitmapImage filled = new BitmapImage(filled_loc);
        //        star2.Source = filled;
        //        IncreaseHappy();
        //    }
        //    else
        //    {
        //        BitmapImage empty = new BitmapImage(empty_loc);
        //        star2.Source = empty;
        //        DecreaseHappy();
        //    }
        //}

        //private void Click_Goal3(object sender, RoutedEventArgs e)
        //{
        //    //Detect the current image
        //    var filled_loc = new Uri("ms-appx:///Assets/Items/Star_Fill.png");
        //    var empty_loc = new Uri("ms-appx:///Assets/Items/Star_Empty.png");
        //    if (star3.Source.GetType() == typeof(BitmapImage) && (star3.Source as BitmapImage).UriSource.Equals(empty_loc))
        //    {
        //        BitmapImage filled = new BitmapImage(filled_loc);
        //        star3.Source = filled;
        //        IncreaseHappy();
        //    }
        //    else
        //    {
        //        BitmapImage empty = new BitmapImage(empty_loc);
        //        star3.Source = empty;
        //        DecreaseHappy();
        //    }
        //}

        //private void Click_Goal4(object sender, RoutedEventArgs e)
        //{
        //    //Detect the current image
        //    var filled_loc = new Uri("ms-appx:///Assets/Items/Star_Fill.png");
        //    var empty_loc = new Uri("ms-appx:///Assets/Items/Star_Empty.png");
        //    if (star4.Source.GetType() == typeof(BitmapImage) && (star4.Source as BitmapImage).UriSource.Equals(empty_loc))
        //    {
        //        BitmapImage filled = new BitmapImage(filled_loc);
        //        star4.Source = filled;
        //        IncreaseHappy();
        //    }
        //    else
        //    {
        //        BitmapImage empty = new BitmapImage(empty_loc);
        //        star4.Source = empty;
        //        DecreaseHappy();
        //    }
        //}
        //private void Click_Goal5(object sender, RoutedEventArgs e)
        //{
        //    //Detect the current image
        //    var filled_loc = new Uri("ms-appx:///Assets/Items/Star_Fill.png");
        //    var empty_loc = new Uri("ms-appx:///Assets/Items/Star_Empty.png");
        //    if (star5.Source.GetType() == typeof(BitmapImage) && (star5.Source as BitmapImage).UriSource.Equals(empty_loc))
        //    {
        //        BitmapImage filled = new BitmapImage(filled_loc);
        //        star5.Source = filled;
        //        IncreaseHappy();
        //    }
        //    else
        //    {
        //        BitmapImage empty = new BitmapImage(empty_loc);
        //        star5.Source = empty;
        //        DecreaseHappy();
        //    }
        //}


    }
}