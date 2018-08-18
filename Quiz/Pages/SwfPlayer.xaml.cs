using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Quiz.Pages
{
    /// <summary>
    /// Interaction logic for SwfPlayer.xaml
    /// </summary>
    /// 
    public partial class SwfPlayer : Window
    {
    

        private int curVedio =0;
        int tVedio = 3;
        decimal[] vCode;
        private double keyframe;
        private double inc;
        ShockFlash.schockwave player = new ShockFlash.schockwave();

        ShockFlash.winPalyer winPalyer = new ShockFlash.winPalyer();

        DispatcherTimer dt = new DispatcherTimer();
        string strFilePath;
        bool play;
        private double timeStamp; 
        WindowsFormsHost host = new WindowsFormsHost();
        public SwfPlayer()
        {
            InitializeComponent();
            vCode = new decimal[4];
            vCode[0] = 1531389123;
            vCode[1] = 1531389124;
            vCode[2] = 1531389125;
            vCode[3] = 1531389126;
            dt = new DispatcherTimer();
            strFilePath = Environment.CurrentDirectory +  @"\Vedios\video-" + vCode[0] + ".swf";
            //player = new ShockFlash.schockwave();



            ////the Windows Forms Host hosts the Flash Player
            //host.Child = player;

            ////the WPF Grid hosts the Windows Forms Host
            //grid1.Children.Add(host);

            ////set size
            //player.Width = (int)this.Width;
            //player.Height = (int)this.Height;

            //total.Content = curVedio + " out of " + 4;
            //curVedio = curVedio + 1;
            //player.LoadMovie(strFilePath);

            //player.Play();
            //keyframe = player.KeyFrame();
            //timeStamp = keyframe / 25;
            //slider.Value = 0;
            //slider.Maximum = timeStamp;
            //slider.Minimum = 0;

            host.Child = winPalyer;
            grid1.Children.Add(host);
            player.Width = (int)this.Width;
            player.Height = (int)this.Height;
            dt.Interval = TimeSpan.FromMilliseconds(100);
            dt.Tick += dtTicker;
            dt.Start();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (curVedio < tVedio)
                
            {
                curVedio = curVedio + 1;
                total.Content = curVedio + " out of " + 4;
                
                strFilePath = Environment.CurrentDirectory + @"\Vedios\video-" + vCode[curVedio] + ".swf";
                player.LoadMovie(strFilePath);
                player.Play();
                keyframe = player.KeyFrame();
                timeStamp = keyframe;
                slider.Value = 0;
                slider.Maximum = timeStamp;
                slider.Minimum = 0;
            }
           
            //load & play the movie



        }

        private void dtTicker(object sender, EventArgs e)
        {
            inc += 1;
            if (timeStamp != inc)
            {
               
                slider.Value = inc;
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            player.Stop();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            if (play)
            {
                player.Stop();
                play = false;
                return;

            }
            else { play = true; }
            total.Content = curVedio + " out of " + 4;
            curVedio = curVedio + 1;
            player.LoadMovie(strFilePath);

            player.Play();
            keyframe = player.KeyFrame();
            timeStamp = keyframe/25;
            slider.Value = 0;
            slider.Maximum = timeStamp;
            slider.Minimum = 0;

            dt.Interval = TimeSpan.FromMilliseconds(100);
            dt.Tick += dtTicker;
            dt.Start();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (curVedio > 1)
                
            {
                player.Stop();
                curVedio = curVedio - 1;
                total.Content = curVedio + " out of " + 4;
                strFilePath = Environment.CurrentDirectory + @"\Vedios\video-" + vCode[curVedio] + ".swf";
                player.LoadMovie(strFilePath);
                player.Play();
                keyframe = player.KeyFrame();
                timeStamp = keyframe;

                slider.Value = 0;
                slider.Maximum = timeStamp;
                slider.Minimum = 0;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //grid1.Children.Remove(host);
            

            ////set size
            //player.Width = (int)this.Width;
            //player.Height = (int)this.Height;
            //control.Children.Remove(ctrl);
          //  control1.Children.Add(ctrl);
         //   Panel.SetZIndex(full, 1);

          //  full.Children.Add(host);
         //   Panel.SetZIndex(full, 0);

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            player.Mutesound();
        }
    }
    
}
