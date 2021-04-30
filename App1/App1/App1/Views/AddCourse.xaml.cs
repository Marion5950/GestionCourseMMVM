using App1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views

{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddCourse : ContentPage
    {
        public AddCourse(ListView listeCourse)
        {
            InitializeComponent();
            BindingContext = new AddCourseViewModel(Navigation, listeCourse);
        }
    }
}



