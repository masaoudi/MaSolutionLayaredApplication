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
using BakingApp.L3.Cient.Wpf.OddoServiceReference;
namespace BakingApp.L3.Cient.Wpf
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var num = txtNum.Text;
            var proxy = new ServiceConsultationClient();
            proxy.ConsulterSoldeCompleted += Proxy_ConsulterSoldeCompleted;
            proxy.ConsulterSoldeAsync(num);
           // var solde = proxy.ConsulterSolde(num); // Appel synchrone
           // lbSolde.Content = solde;
        }

        private void Proxy_ConsulterSoldeCompleted(object sender, ConsulterSoldeCompletedEventArgs e)
        {
            lbSolde.Content = e.Result;
        }
    }
}
