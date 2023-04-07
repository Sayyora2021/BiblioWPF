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
using BiblioWpf.ViewModel;

namespace BiblioWpf
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new BiblioWpf.ViewModel.MainViewModel();
        }

        private void btLivre_Click(object sender, RoutedEventArgs e)
        {
            GestionLivres gl = new GestionLivres();
            gl.ShowDialog();
        }

        private void btPersonne_Click(object sender, RoutedEventArgs e)
        {
            GestionPersonnes gp = new GestionPersonnes();
            gp.ShowDialog();
        }

        private void btDomaine_Click(object sender, RoutedEventArgs e)
        {
            GestionDomaines gd = new GestionDomaines(); 
            gd.ShowDialog();
        }
    }
}
