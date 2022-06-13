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

namespace WpfApp1
{
    /// <summary>
    /// Interakční logika pro oknovysledek.xaml
    /// </summary>
    public partial class oknovysledek : Window
    {
        public oknovysledek(bool vyhral)
        {
            InitializeComponent();
            if( vyhral)
            {
                imgResult.Source = new BitmapImage(new Uri(@"obrazky/idk.png", UriKind.Relative));
            }
            else
                {
                imgResult.Source = new BitmapImage(new Uri(@"obrazky/spatne.png", UriKind.Relative));
                }
        }
    }
}
