using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsControls.NavigationPageFolder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageThree : ContentPage
    {
        public PageThree()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("UYARI", "Sen artık 3.Sayfadasın","Tamam");
            await Navigation.PopAsync();
        }
    }
}