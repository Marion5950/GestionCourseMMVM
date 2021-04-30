using App1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewCourses : ContentPage
    {
        public ListViewCourses()
        {
            InitializeComponent();
            BindingContext = new ListeCourseViewModel(Navigation, ListeCourses, ListeCoureurs);
        }
    }
}
