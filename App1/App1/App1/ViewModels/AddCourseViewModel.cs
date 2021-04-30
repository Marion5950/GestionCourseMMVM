using App1.Models;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class AddCourseViewModel : BindableObject
    {
        private Course _course;
        public Course Course { get => _course; set { _course = value; OnPropertyChanged(); } }
        public INavigation Navigation { get; set; }
        public Command ActionNavigationRetourCourse { get; set; }
        
        public Command ActionValiderInscrCourse { get; set; }
        private ListView _listeCourse;

        public AddCourseViewModel(INavigation navigation, ListView listeCourse)
        {
            if (Course == null)
                Course = new Course();
            _listeCourse = listeCourse;
            Navigation = navigation;
            Navigation = navigation;
            ActionNavigationRetourCourse = new Command(InscriptionCourseToListView);
            ActionValiderInscrCourse = new Command(ValiderCourse);
        }

        private void InscriptionCourseToListView(object obj)
        {
            Navigation.PopModalAsync();
        }

        private void ValiderCourse(object obj)
        {
            if (Course.Nom != string.Empty && Course.Lieu != string.Empty && Course.Distance.ToString() != string.Empty)
            {
                App.ListeCourses.Add(Course);
                _listeCourse.ItemsSource = null;
                _listeCourse.ItemsSource = App.ListeCourses;

            }


        }

    }
}