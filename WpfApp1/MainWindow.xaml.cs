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

namespace WpfApp1
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

        private void btnOdeslat_Click(object sender, RoutedEventArgs e)
        {
            string odpoved1 = txtOdpoved1.Text;
            string odpoved2 = txtOdpoved2.Text;
            string odpoved3 = txtOdpoved3.Text;
            int pocetSpravnychOdpovedi = 0;

            if (odpoved1 == "Praha")
            {
                pocetSpravnychOdpovedi++;
            }
            if (odpoved2 == "Brno")
            {
                pocetSpravnychOdpovedi++;
            }
            if (odpoved3 == "Ostrava")
            {
                pocetSpravnychOdpovedi++;
            }

            if(pocetSpravnychOdpovedi == 3)
            {
                oknovysledek okno = new oknovysledek(true);
                okno.Show();
            }
            else if (pocetSpravnychOdpovedi >=0 &&pocetSpravnychOdpovedi < 3)
            {
                oknovysledek okno = new oknovysledek(false);
                okno.Show();
            }

                    
                
        }
    }
}
