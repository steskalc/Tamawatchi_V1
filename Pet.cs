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


namespace Tamawatchi_V1
{

    public partial class Pet
    {
        int m_id;
        string m_name;
        double m_happiness;
        double m_hunger;
        BitmapImage m_img = new BitmapImage();

        public Pet()
        {
            m_id = 1;
            m_name = "default";
            m_happiness = 100.0;
            m_hunger = 0.0;
            BitmapImage m_img = new BitmapImage();
        }

        public Pet(int id, string name, double happiness, double hunger, string imgPath)
        {
            m_id = id;
            m_name = name;
            m_happiness = happiness;
            m_hunger = hunger;
            m_img = new BitmapImage(new Uri(imgPath));
        }

        public string GetPath()
        {
            return m_img.UriSource.ToString();
        }
        public string ChangeImage(int id)//changes an image based on the given id
        {
            m_id = id;
            m_img = new BitmapImage(/*new Uri("ms-appx:///Assets//PetImages//pet" + m_id + ".png")*/);
            string path = "ms-appx:///Assets//PetImages//pet" + m_id + ".png";

            return path;
        }

    }
}