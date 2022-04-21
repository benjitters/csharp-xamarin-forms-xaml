using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XAMLInXamarinForms.ViewModels;

namespace XAMLInXamarinForms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPageView : ContentPage
    {
        public PlannerViewModel model = new PlannerViewModel();

        public NavigationPageView()
        {
            InitializeComponent();
        }

        private async void FitnessButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(this);
        }

        private async void NutritionButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(this);
        }

    }
}