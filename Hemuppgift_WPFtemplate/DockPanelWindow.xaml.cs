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

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for DockPanelWindow.xaml
    /// </summary>
    public partial class DockPanelWindow : Window
    {
        public DockPanelWindow()
        {
            InitializeComponent();
        }

        private void btnCenter_Click(object sender, RoutedEventArgs e)
        {
            MainDockPanel.Children.Remove(btnCenter);

            Image trophyImage = new Image
            {
                Source = new BitmapImage(new Uri("TrophyImage.jpg", UriKind.Relative)),
                Stretch = Stretch.Uniform
            };

            MainDockPanel.Children.Add(trophyImage);
        }
    }
}
