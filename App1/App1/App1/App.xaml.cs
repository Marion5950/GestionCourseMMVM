using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.ViewModels;
using System.Collections.Generic;
using App1.Models;
using App1.Views;

namespace App1
{
    public partial class App : Application
    {
        public static List<Course> ListeCourses { get; set; }
        public static List<Coureur> ListeCoureurs { get; set; }


        public App()
        {
            InitializeComponent();

            if (ListeCourses == null)
                ListeCourses = new List<Course>();
            if (ListeCoureurs == null)
                ListeCoureurs = new List<Coureur>();
            InitialisationListeCourse();

            MainPage = new ListViewCourses();
           
        }

        private void InitialisationListeCourse()
        {
            ListeCourses.Add(new Course { Nom = "Marathon de Paris", Lieu = "Paris", Distance = 42.195f });
            
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
