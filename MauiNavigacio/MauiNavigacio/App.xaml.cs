﻿using MauiNavigacio.mvvm.views;

namespace MauiNavigacio
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StartPage());
        }
    }
}
