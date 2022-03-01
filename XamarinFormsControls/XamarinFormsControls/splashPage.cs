using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsControls
{
    public class splashPage : ContentPage
    {
        Image splashImage;

        public splashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);    //Açacağım nagigation barda nav bar istemediğim için false yaptım.

            var sub = new AbsoluteLayout();        
            splashImage = new Image         //Yukarda oluşturduğum image yi splashImage ye set ettim.
            {
                Source = "yapayzeka.jpg",
                WidthRequest = 300,
                HeightRequest = 300
            };

            AbsoluteLayout.SetLayoutFlags(splashImage,          //Layout ekledik 
               AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage,
             new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));    //Propertylerini set ettim

            sub.Children.Add(splashImage);          //Children ile splash ımageyi eklemiş olsuk ->0.5, 0.5

            //this.BackgroundColor = Color.FromHex("#429de3"0);
            this.BackgroundColor = Color.White;
            this.Content = sub;     //Contenti set ettik AbsoluteLayout'a..
        }

        protected async override void OnAppearing()
        {       //4 sn bekle sonra bir navigationPage eline al, bunu aftersplasch page'e parametre olarak geç ve daha sonra
            //Current.MainPage propertysinde az önce elime aldığım nav page e set et
            base.OnAppearing();
            await Task.Delay(4000);

            NavigationPage navPage = new NavigationPage(new AfterSplashPage())
            {
                BarBackgroundColor = Color.FromHex("#003a67"),
                BarTextColor = Color.White

            };
            Application.Current.MainPage = navPage;


        }
    }

}
