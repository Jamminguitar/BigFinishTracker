using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Big_Finish_Tracker.MVVM.View
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void Big_Finish_Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.bigfinish.com/whats_new");
        }

        private void Spotify_Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://open.spotify.com/user/xc0ffw9n43c23yficyajnpkhj");
        }
    }
}
