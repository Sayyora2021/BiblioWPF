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
    /// Logique d'interaction pour GestionLivres.xaml
    /// </summary>
    public partial class GestionLivres : Window
    {
        public GestionLivres()
        {
            InitializeComponent();
            DataContext = new BiblioWpf.ViewModel.MainViewModel();

        }
        private void btAjouter_Click(object sender, RoutedEventArgs e)
        {
            Livre l = new Livre();
            l.tittre = tbTitre.Text;
            l.nbPage = int.Parse(tbNbPages.Text);

            l.idPersonneNavigation = cbbLecteur.SelectedItem as Personne;
            l.idDomaineNavigation = cbbDomaines.SelectedItem as Domaine;

            MainViewModel model = (MainViewModel)this.DataContext;
            model.AddLivre(l);
        }

        private void lbLivres_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            Livre l = lbLivres.SelectedItem as Livre;
            if(l != null) {

                tbNbPages.Text = l.nbPage.ToString();
                tbTitre.Text = l.tittre.ToString();
                cbbDomaines.SelectedItem = l.idDomaineNavigation;
                cbbLecteur.SelectedItem = l.idPersonneNavigation;
            }
            
        }

        private void btModifier_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel model = (MainViewModel)this.DataContext;
            Livre l = lbLivres.SelectedItem as Livre;
            l.tittre = tbTitre.Text;
            l.nbPage = int.Parse(tbNbPages.Text);

            l.idPersonneNavigation = cbbLecteur.SelectedItem as Personne;
            l.idDomaineNavigation = cbbDomaines.SelectedItem as Domaine;
            model.UpdateLivre(l);
        }

        private void btSupprimer_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel model = (MainViewModel)this.DataContext;
            Livre l = lbLivres.SelectedItem as Livre;
            model.DeleteLivre(l);

        }
    }
}
