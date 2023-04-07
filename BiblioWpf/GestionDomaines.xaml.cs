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
using BData.Models;
using BiblioWpf.ViewModel;

namespace BiblioWpf
{
    /// <summary>
    /// Logique d'interaction pour GestionDomaines.xaml
    /// </summary>
    public partial class GestionDomaines : Window
    {
        public GestionDomaines()
        {
            InitializeComponent();
            this.DataContext  = new BiblioWpf.ViewModel.MainViewModel();
        }

        private void btAjouter_Click(object sender, RoutedEventArgs e)
        {
            Domaine d = new Domaine();
            d.nom = tbNom.Text;
            d.description = tbDesciption.Text;

            MainViewModel model = (MainViewModel)this.DataContext;
            model.AddDomaine(d);

        }
    }
}
