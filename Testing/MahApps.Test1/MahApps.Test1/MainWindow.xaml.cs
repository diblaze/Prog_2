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
using MahApps.Metro.Controls;

namespace MahApps.Test1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
        {
        private List<string> collectionStrings = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            collectionStrings.Add("Idag var det brandövning vid klockan 12.00.");
            collectionStrings.Add("Denna informationsdisplay gjordes som ett gymnasiearbete av före detta teknikelev Denis Ivan Blazevic (Te13in)." );
        }

        private void BtnGetInfoClick(object sender, RoutedEventArgs e)
        {
            if ( collectionStrings == null )
            {
                MessageBox.Show( @"No more strings to show!" );
                return;
            }
            textBlock1.Text = string.Empty;
            StringBuilder stringBuilder = new StringBuilder();
            foreach ( string text in collectionStrings )
            {
                textBlock1.Text += text + "\n";
                
            }
            collectionStrings.Clear();

        }
    }
}
