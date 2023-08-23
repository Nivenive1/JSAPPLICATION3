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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JSAPPLICATION3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void lblgreen_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lblmain.Background = lblgreen.Background;
        }

        private void lblmagenta_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lblmain.Background = lblmagenta.Background;
        }

        private void lblblack_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lblmain.Background = lblblack.Background;
        }

        private void lblpink_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lblmain.Background = lblpink.Background;
        }

        private void lblgray_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lblmain.Background = lblgray.Background;
        }

        private void lbldarkblue_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lblmain.Background = lbldarkblue.Background;
        }

        private void lblred_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lblmain.Background = lblred.Background;
        }

        private void lblmaroon_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lblmain.Background = lblmaroon.Background;
        }

        private void lblmain_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void lbldarkviolet_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lblmain.Background = lbldarkviolet.Background;
        }

        private void lblblue_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lblmain.Background = lblblue.Background;
        }

        private void lblpalevioletred_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lblmain.Background = lblpalevioletred.Background;
        }
    }
}
