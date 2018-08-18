using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Quiz.Pages
{
    /// <summary>
    /// Interaction logic for player.xaml
    /// </summary>
    public partial class player : Window
    {
        [DllImport("user32.dll")]
        private static extern uint GetDoubleClickTime();
        DispatcherTimer timer;
        bool isDraging;
        bool fullscreen;
        List<FileList> fileList = new List<FileList>();
        int CurIndx;
        FileList Flist = new FileList();
        public player()
        {
            Flist = new FileList();


            this.DataContext = Flist;
            InitializeComponent();
            CurIndx = 0;

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(200);
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //timelineSlider.Value = 20000;
            if (!isDraging)
            {
                timelineSlider.Value = McMediaElement.Position.TotalSeconds;
            }
        }

      

        private void Element_MediaEnded(object sender, RoutedEventArgs e)
        {

        }

        // Play the media.
        void OnMouseDownPlayMedia(object sender, RoutedEventArgs args)
        {

            // The Play method will begin the media if it is not currently active or 
            // resume media if it is paused. This has no effect if the media is
            // already running.
            if (fileList.Count > 0)
            {
                if (play.Content.ToString() == "4")
                {
                    McMediaElement.Play();
                    play.Content = ";";

                    // Initialize the MediaElement property values.
                    InitializePropertyValues();
                }
                else
                {
                    play.Content = "4";
                    McMediaElement.Pause();


                }
            }
        }

        // Pause the media.
        void OnMouseDownPauseMedia(object sender, RoutedEventArgs args)
        {

            // The Pause method pauses the media if it is currently running.
            // The Play method can be used to resume.
            if (McMediaElement.LoadedBehavior == MediaState.Pause)
            {
                McMediaElement.Play();
            }
            else { McMediaElement.Pause();
            }
            
            

        }

        // Stop the media.
        void OnMouseDownStopMedia(object sender, RoutedEventArgs args)
        {

            // The Stop method stops and resets the media to be played from
            // the beginning.
            
            McMediaElement.Stop();
            play.Content = "4";
        }

        // Change the volume of the media.
        private void ChangeMediaVolume(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            McMediaElement.Volume = (double)volumeSlider.Value;
        }

        // Change the speed of the media.
        private void ChangeMediaSpeedRatio(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            McMediaElement.SpeedRatio = (double)speedRatioSlider.Value;
        }

        // When the media opens, initialize the "Seek To" slider maximum value
        // to the total number of miliseconds in the length of the media clip.
        private void Element_MediaOpened(object sender, EventArgs e)
        {
            try {
                if (McMediaElement.NaturalDuration.HasTimeSpan) {
                    TimeSpan ts = McMediaElement.NaturalDuration.TimeSpan;
                    timelineSlider.Maximum = ts.Hours *60*60 + ts.Minutes * 60+ ts.Seconds;
                    timelineSlider.SmallChange = 1;
                    timelineSlider.LargeChange = Math.Min(10, ts.Seconds / 10);
                }
                timer.Start();
            }
            catch {; }
        }

        // When the media playback is finished. Stop() the media to seek to media start.
        private void Element_MediaEnded(object sender, EventArgs e)
        {
            McMediaElement.Stop();
        }

        // Jump to different parts of the media (seek to). 
        private void SeekToMediaPosition(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            int SliderValue = (int)timelineSlider.Value;

            //// Overloaded constructor takes the arguments days, hours, minutes, seconds, miniseconds.
            //// Create a TimeSpan with miliseconds equal to the slider value.
            //TimeSpan ts = new TimeSpan(0, 0, 0, 0, SliderValue);
            //McMediaElement.Position = ts;
        }

        void InitializePropertyValues()
        {
         //   this.Cursor = System.Windows.Input.Cursors.None;
            // Set the media's starting Volume and SpeedRatio to the current value of the
            // their respective slider controls.
            McMediaElement.Volume = (double)volumeSlider.Value;
            McMediaElement.SpeedRatio = (double)speedRatioSlider.Value;
        }

        private void BrowseButtonClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Environment.CurrentDirectory; //"c:\\";
            dlg.Filter = "Media files (*.wmv)|*.wmv|All Files (*.*)|*.*";
           
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               var a = Regex.Split(dlg.FileName.ToString(), @"\\");
                getMediaFileList(a[0]);
                if (fileList.Count > 0)
                {
                    CurIndx = fileList.FindIndex(x => x.MediaList == dlg.FileName.ToString());   
                }
                string selectedFileName = dlg.FileName;
                this.DataContext = selectedFileName;
                //FileNameLabel.Content = selectedFileName;
                McMediaElement.Source = new Uri(selectedFileName);
                McMediaElement.Play();
                play.Content = ";";
            }
        }

        private void getMediaFileList(string Directory)
        {
            DirectoryInfo d = new DirectoryInfo(Directory);//Assuming Test is your Folder
            string[] extensions = new[] { ".mp4", ".wmv", ".wma" , ".mp3" , ".avi", ".mkv" };
            FileInfo[] Files = d.GetFiles().Where(f => extensions.Contains(f.Extension.ToLower())).ToArray(); //Getting Text files
            fileList = new List<FileList>();
            foreach (FileInfo file in Files)
            {
                fileList.Add( new FileList { MediaList = Directory.ToString() + "\\" + file.Name.ToString() });
            }
            return ;
        }


        private void timelineSlider_DragEnter(object sender, System.Windows.DragEventArgs e)
        {
            int SliderValue = (int)timelineSlider.Value;

            // Overloaded constructor takes the arguments days, hours, minutes, seconds, miniseconds.
            // Create a TimeSpan with miliseconds equal to the slider value.
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, SliderValue);
            McMediaElement.Position = ts;
        }

        private void timelineSlider_PreviewDragEnter(object sender, System.Windows.DragEventArgs e)
        {

        }

        private void timelineSlider_DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            isDraging = true;
        }

        private void timelineSlider_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            isDraging = false;
            McMediaElement.Position = TimeSpan.FromSeconds(timelineSlider.Value);
        }

        private void OnMouseDownReloadMedia(object sender, RoutedEventArgs e)
        {
            McMediaElement.Position = new TimeSpan(0, 0, 0, 0, 1);
            McMediaElement.Play();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (McMediaElement.IsMuted)
            {
                Mute.Visibility = Visibility.Collapsed;
                McMediaElement.IsMuted = false;
            }
            else { McMediaElement.IsMuted = true;
                Mute.Visibility = Visibility.Visible;
            }
            
        }

        private void McMediaElement_SizeChanged(object sender, SizeChangedEventArgs e)
        {
         
                (sender as MediaElement).Height = (e.NewSize.Width * 0.5625);
        
        }

        private void animiation(string target_name)
        {
            Storyboard testStoryboard = new Storyboard();
            testStoryboard.SetValue(Storyboard.TargetNameProperty, target_name);
            testStoryboard.Begin();
        }

        private void McMediaElement_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if(!timer.IsEnabled)
            {
                timer.Start();
            }
            else
            {
               
                if (!fullscreen)
                {
                    this.WindowStyle = WindowStyle.None;
                    this.WindowState = WindowState.Maximized;
                }
                else
                {
                    this.WindowStyle = WindowStyle.SingleBorderWindow;
                    this.WindowState = WindowState.Normal;
                }

                fullscreen = !fullscreen;
            }
          
        }

        public class FileList
        {
            public string MediaList { get; set; }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Flist = new FileList();
            string selectedFileName;
            if (fileList.Count > 0 && CurIndx < fileList.Count)
            {
                selectedFileName =fileList[CurIndx + 1].MediaList;
                if (selectedFileName != null)
                {

                    var a = Regex.Split(selectedFileName, @"\\");
                    Flist.MediaList = a[1];
                    this.DataContext = Flist;
                    McMediaElement.Source = new Uri(selectedFileName);
                    McMediaElement.Play();
                    play.Content = ";";
                    CurIndx += 1;
                }
                    
            }
           
            //FileNameLabel.Content = selectedFileName;
           
           
        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            Flist = new FileList();
            string selectedFileName;
            if (fileList.Count > 0 && CurIndx > 1)
            {
                selectedFileName = fileList[CurIndx - 1].MediaList;
                if (selectedFileName != null)
                {
                    var a = Regex.Split(selectedFileName, @"\\");
                    Flist.MediaList = a[1];
                    this.DataContext = Flist;
                    McMediaElement.Source = new Uri(selectedFileName);
                    McMediaElement.Play();
                    play.Content = ";";
                    CurIndx -= 1;
                }

            }
        }
    }
}
