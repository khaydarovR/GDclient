﻿using MauiAppMapTest.Page;

namespace MauiAppMapTest
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {

            InitializeComponent();
/*
            var mapControl = new Mapsui.UI.Maui.MapControl();
            var r = Mapsui.Tiling.OpenStreetMap.CreateTileLayer();
            mapControl.Map?.Layers.Add(r);
            Task.Delay(1000);
            Content = mapControl;
            Task.Delay(1000);*/
        }


        private void OnClickToPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PosPage());

        }

        protected override async void OnNavigatedTo(NavigatedToEventArgs args)
        {
            if (isAuthenticated())
            {
                await Shell.Current.GoToAsync("///home");
            }
            else
            {
                await Shell.Current.GoToAsync("login");
            }
            base.OnNavigatedTo(args);
        }

        bool isAuthenticated()
        {
            var hasAuth = Preferences.Get("JWT", null);
            return !(hasAuth == null);
        }
    }

}
