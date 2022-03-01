using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsControls.Data;

namespace XamarinFormsControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewSamplePage : ContentPage
    {
        List<Users> myRealist = new List<Users>();


        public ListViewSamplePage()
        {
            InitializeComponent();

            //var myList = new List<string>
            //{
            //       "Tarık",
            //       "Murat",
            //       "Ersin"
            //};

            var myList = new List<Users>
            {
                new Users {userName = "Tarık", userId = "0007", imageUrl="https://image.freepik.com/free-photo/portrait-asian-business-man-business-district-lifestyle-business-people-concept_1150-34747.jpg"},
                new Users {userName= "Murat", userId = "0008", imageUrl="https://t3.ftcdn.net/jpg/02/79/82/68/360_F_279826857_ThOTadb7a6naSXaSCBTkw7jUFX4qly45.jpg"},
                new Users {userName= "Ersin", userId = "0009", imageUrl="https://www.thefashionisto.com/wp-content/uploads/2019/07/Male-Model-Businessman-Suit-900x600.jpg"}
            };
            myRealist = myList;

            myListView.ItemsSource = myRealist;
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            myRealist.Add(new Users { userName = "Ahmet", userId = "00019", imageUrl = "https://media.istockphoto.com/photos/successful-businessman-in-modern-office-picture-id1189302146?k=20&m=1189302146&s=612x612&w=0&h=2qsMrsRKD_9b07maCcQBP92QjXcuOmrEKKek0Uypdx4=" });
            myRealist.Add(new Users { userName = "Ersin", userId = "00019", imageUrl = "https://www.thefashionisto.com/wp-content/uploads/2019/07/Male-Model-Businessman-Suit-900x600.jpg" });
            myListView.ItemsSource = null;
            myListView.ItemsSource = myRealist;
                
        }
        //userıd yi ilgili satırdan aldım, menuıtem la commentParameter yardımı ile gönderdim ve bunu da link yardımı ile listemden sildim ve ıtemsource sini set etim. 
        private void onDelete_Clicked(object sender, EventArgs e)
        {
            var myMenuItem = (MenuItem)sender;              //casting işlemi; tıklanan değişkenin türünü bulmaya yarıyor:sender
            var userID = myMenuItem.CommandParameter.ToString();    
            myRealist.RemoveAll(r => r.userId == userID);           //Benim commend parametremden gelen userıd userID ye eşitse kaldır. removeAll:hepsini kaldır - linq  
            myListView.ItemsSource = null;                         //count 3, silince 2 kalıyor ancak listview bunu hala 3 algıladığı için 2elemanlı bir liste set etmeye çalışınca hata verir bunu düzeltmek için yazıldı.
            myListView.ItemsSource = myRealist;
            
        }

        //Örneğin dataları servisten çekiyorum listview datalarını,bunların yüklenmesini bekliceksek böyle birşey yapabiliriz;
        private async void myListView_Refreshing(object sender, EventArgs e)        //Kod buraya gelince bekliyeceği için asyc yapıldı.
        {
            myListView.IsRefreshing = true;         //Bunu refresh et
            await Task.Delay(4000);                 //4 sn bekle
            myListView.IsRefreshing = false;        //Servisten data çekme işlemi bitti, artık bunu false edebilirsin. 

        }
    }
}