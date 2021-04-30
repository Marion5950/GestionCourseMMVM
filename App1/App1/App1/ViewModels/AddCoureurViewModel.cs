using App1.Models;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class AddCoureurViewModel : BindableObject
    {
        private Coureur _coureur;
        public Coureur Coureur { get => _coureur; set { _coureur = value; OnPropertyChanged(); } }
        public INavigation Navigation { get; set; }
        public Command ActionNavigationRetour { get; set; }
        public Command ActionValiderInscrCoureur { get; set; }

        private ListView _listeCoureur;
        public AddCoureurViewModel(INavigation navigation,ListView listeCoureur)
        {
            if (Coureur == null)
                Coureur = new Coureur();
            _listeCoureur = listeCoureur;
            Navigation = navigation;
            ActionNavigationRetour = new Command(InscriptionToListView);
            ActionValiderInscrCoureur = new Command(ValiderCoureur);
        }

        private void InscriptionToListView(object obj)
        {
            Navigation.PopModalAsync();

        }

        private void ValiderCoureur(object obj)
        {
            if (Coureur.Nom != string.Empty && Coureur.Prenom != string.Empty && Coureur.Age.ToString() != string.Empty && Coureur.Sexe.ToString() != string.Empty)
            {
                App.ListeCoureurs.Add(Coureur);
                _listeCoureur.ItemsSource = null;
                _listeCoureur.ItemsSource = App.ListeCoureurs;

            }

        }
    }
}



   