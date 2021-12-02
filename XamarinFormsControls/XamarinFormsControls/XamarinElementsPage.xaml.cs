using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XamarinElementsPage : ContentPage
    {
        public XamarinElementsPage()
        {
            InitializeComponent();
        }

        private void myButton_Clicked(object sender, EventArgs e)
        {
            myEntry.Text = "Merhaba Xamarin.forms";
            myLabel.Text = "Merhaba Xamarin Label";
            mySlider.Value = 50;
            myDatePicker.Date = new DateTime(2017, 7, 18);
            myTimePicker.Time = new TimeSpan(4, 45, 34);
            mySwitch.IsToggled = true;
            myButton.Text = "You push me";

            var myList = new List<String>();
            myList.Add("First İtem");
            myList.Add("Second İtem");
            myList.Add("Third İtem");
            myList.Add("Fourth İtem");

            myPicker.ItemsSource = myList;

        }

        private void myPicker_SelectedIndexChanged(object sender, EventArgs e)          //Pickerda seçilen ıtemın değiştirğini yakalayan ıvent 
        {
            myEntry.Text = myPicker.SelectedItem.ToString();        //Seçilen ıtem Entry ye atılıyor orda gözükmesi için, Obje türü tutulduğu için  Stringe çevirdik
        }
    }
}
