using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Quiz.Pages
{
    /// <summary>
    /// Interaction logic for WinMediaPlayer.xaml
    /// </summary>
    public partial class WinMediaPlayer : Window
    {
        public WinMediaPlayer()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            axMedia.FileName = "f:\\videoplayback.MP4";
            axMedia.Play();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            axMedia.ShowFullScreen(true);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            axMedia.Stop();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            axMedia.SoundVolume = 0;
            //axMedia.Pause();
          
        }
    }
}
