﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsControls
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ButonTestPages();
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