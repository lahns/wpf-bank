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

namespace bank
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

        private double stanKonta = 0;

        private void pokazStanKonta(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(String.Format("Na twoim koncie znajduje sie {0} PLN", stanKonta));
        }

        private void wplacKase(object sender, RoutedEventArgs e)
        {
            string kwotaWplatyStr = kwotaWplaty.Text;
            stanKonta += Convert.ToDouble(kwotaWplatyStr);
            MessageBox.Show(String.Format("Sukces! Na twoje konto wplynelo {0} PLN", kwotaWplatyStr));
            
        }

        private void wykonajPrzelew(object sender, RoutedEventArgs e)
        {
            string numerKontaStr = numerKonta.Text;
            string kwotaPrzelewuStr = kwotaPrzelewu.Text;
            double ileDoPrzelania = Convert.ToDouble(kwotaPrzelewuStr);

            if (stanKonta >= ileDoPrzelania)
            {
                stanKonta -= ileDoPrzelania;
                MessageBox.Show(String.Format("Przelales {0} PLN na konto o numerze {1}. Twoj stan konta wynosi teraz: {2}", ileDoPrzelania, numerKontaStr, stanKonta));
            }
            else
            {
                MessageBox.Show("Niewystarczajace srodki na koncie, by wykonac przelew");
            }


        }
    }
}
