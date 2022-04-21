using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XAMLInXamarinForms.ViewModels;
using XAMLInXamarinForms.Views.Nutrition;
using XAMLInXamarinForms.Views.Fitness;

namespace XAMLInXamarinForms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPageView : ContentPage
    {
        public PlannerViewModel model = new PlannerViewModel();

        public NavigationPageView()
        {
            InitializeComponent();
            PopModal();
        }

        private async void FitnessButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new FitnessView());
        }

        private async void NutritionButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new NutritionView());
        }
        private async void PopModal()
        {
            await this.Navigation.PushModalAsync(new PrivacyModal(), true);
        }
    }
}