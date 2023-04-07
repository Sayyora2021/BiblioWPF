using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer;
using BData.Models;


namespace BiblioWpf.ViewModel
{
        public class MainViewModel : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;
            private BiblioContext _context = new BiblioContext();

            readonly Lazy<ObservableCollection<Role>> _roles;
            readonly Lazy<ObservableCollection<Domaine>> _domaines;
            readonly Lazy<ObservableCollection<Emprunter>> _emprunts;
            readonly Lazy<ObservableCollection<Livre>> _livres;
            readonly Lazy<ObservableCollection<Personne>> _personnes;
            readonly Lazy<ObservableCollection<Adresse>> _adresses;


        public IEnumerable<Role> Roles { get { return _roles.Value; } }
        public IEnumerable<Domaine> Domaines { get { return _domaines.Value; } }
        public IEnumerable<Emprunter> Emprunts { get { return _emprunts.Value; } }
        public IEnumerable<Livre> Livres { get { return _livres.Value; } }
        public IEnumerable<Personne> Personnes { get { return _personnes.Value; } }
        public IEnumerable<Adresse> Adresses { get { return _adresses.Value; } }
        

        public MainViewModel()
        {
            _roles = new Lazy<ObservableCollection<Role>>(() => GetRoles());
            _domaines = new Lazy<ObservableCollection<Domaine>>(() => GetDomaines());
            _personnes = new Lazy<ObservableCollection<Personne>>(() => GetPersonnes());
            _adresses = new Lazy<ObservableCollection<Adresse>>(() => GetAdresses());
            _emprunts = new Lazy<ObservableCollection<Emprunter>>(() => GetEmprunts());
            _livres = new Lazy<ObservableCollection<Livre>>(() => GetLivres());
        }

        private ObservableCollection<Role> GetRoles()
            {
                _context.Role.Load();
                return _context.Role.Local.ToObservableCollection();
        }
        private ObservableCollection<Domaine> GetDomaines()
        {
            _context.Domaine.Load();
            return _context.Domaine.Local.ToObservableCollection();
        }
        private ObservableCollection<Emprunter> GetEmprunts()
        {
            _context.Emprunter.Load();
            return _context.Emprunter.Local.ToObservableCollection();
        }
        private ObservableCollection<Livre> GetLivres()
        {
            _context.Livre.Load();
            return _context.Livre.Local.ToObservableCollection();
        }
        private ObservableCollection<Personne> GetPersonnes()
        {
            _context.Personne.Load();
            return _context.Personne.Local.ToObservableCollection();
        }
        private ObservableCollection<Adresse> GetAdresses()
        {
            _context.Adresse.Load();
            return _context.Adresse.Local.ToObservableCollection();
        }

        public void AddDomaine(Domaine domaine)
        {
            _context.Domaine.Add(domaine);
            _context.SaveChanges();
        }

        public void AddPersonne(Personne personne)
        {
            _context.Personne.Add(personne);
            _context.SaveChanges();
        }
        public void AddAdresse(Adresse adresse)
        {
            _context.Adresse.Add(adresse);
            _context.SaveChanges();
        }
        public void AddLivre(Livre livre)
        {
            _context.Livre.Add(livre);
            _context.SaveChanges();
        }
        public void AddEmprunt(Emprunter emprunt)
        {
            _context.Emprunter.Add(emprunt);
            _context.SaveChanges();
        }

        public void UpdateLivre(Livre livre) {
            _context.Livre.Update(livre);
            _context.SaveChanges(); 
        }

        public void DeleteLivre(Livre livre)
        {
            _context.Livre.Remove(livre);
            _context.SaveChanges(); 
        }
    }
 }

