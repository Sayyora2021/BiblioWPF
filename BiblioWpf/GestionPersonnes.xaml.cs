using BData.Models;
using BiblioWpf.ViewModel;
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

namespace BiblioWpf
{
    /// <summary>
    /// Logique d'interaction pour GestionPersonnes.xaml
    /// </summary>
    public partial class GestionPersonnes : Window
    {
        public GestionPersonnes()
        {
            InitializeComponent();
            DataContext = new BiblioWpf.ViewModel.MainViewModel();
        }

        private void btAjouter_Click(object sender, RoutedEventArgs e)
        {
            Personne p = new Personne();
            p.nom = tbNom.Text;
            p.prenom = tbPrenom.Text;
            p.telephone = tbTelephone.Text;
            p.motDePasse = tbMdpe.Text;
            p.email = tbEmail.Text;

            if(rbLecteur.IsChecked == true) { p.idRole = 2; }
            if (rbAuteur.IsChecked == true) { p.idRole = 3; }
            if (rbAdmin.IsChecked == true) { p.idRole = 1; }

            p.idAdresseNavigation = new Adresse();
            p.idAdresseNavigation.rue = tbAddresse.Text;

            MainViewModel model = (MainViewModel)this.DataContext;
            model.AddPersonne(p);

        }


    }
}
