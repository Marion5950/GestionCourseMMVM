using App1.Models;
using App1.Views;
using System.Collections.Generic;
using Xamarin.Forms;


namespace App1.ViewModels
{
    public class ListeCourseViewModel : BindableObject
    {
        private List<Course> _courses;
        private List<Coureur> _coureurs;

        public List<Course> Courses { get => _courses; set { _courses = value; OnPropertyChanged(); } }
        public List<Coureur> Coureurs { get => _coureurs; set { _coureurs = value; OnPropertyChanged(); } }
        public Command ActionNavigationCourse { get; set; }
        public Command ActionNavigationCoureur { get; set; }
        public Command ActionNavigationRetour { get; set; }
        public INavigation Navigation { get; set; }
        
        private ListView _listeCourses;
        private ListView _listeCoureurs;

        private void InitilisationListeCourse()
        {
          
        }

        public ListeCourseViewModel(INavigation navigation, ListView listeCourses, ListView listeCoureurs)
        {
            if (Courses == null)
                Courses = new List<Course>();
            Courses = App.ListeCourses;
            if (Coureurs == null)
                Coureurs = new List<Coureur>();
            Coureurs = App.ListeCoureurs;
            Navigation = navigation;
            ActionNavigationCourse = new Command(ListViewToInscription);
            ActionNavigationCoureur = new Command(ListViewToAddCoureur);
            _listeCourses = listeCourses;
            _listeCoureurs = listeCoureurs;
        }

        private void ListViewToAddCoureur(object obj)
        {
            Navigation.PushModalAsync(new AddCoureur(_listeCoureurs));
        }

        private void ListViewToInscription(object obj)
        {
            Navigation.PushModalAsync(new AddCourse(_listeCourses));
        }

     
    }
}


