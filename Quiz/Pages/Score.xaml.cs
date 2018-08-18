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
    /// Interaction logic for Score.xaml
    /// </summary>
    public partial class Score : Window
    {
        public Score()
        {
            InitializeComponent();
        }
        public Score(string title,int ans,int qno)
        {
            InitializeComponent();
            Decription.Content = "You Have Correctly answered " + ans + " out of "+ qno + " questions.";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
