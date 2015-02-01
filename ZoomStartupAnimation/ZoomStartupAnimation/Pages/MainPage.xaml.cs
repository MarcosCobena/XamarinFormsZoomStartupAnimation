using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ZoomStartupAnimation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            StartAgainButton.Clicked += (sender, args) =>
                // NOTE: This will generate an infinite navigation, don't do this on real scenarios
                Navigation.PushAsync(new LoadingPage());
        }
    }
}

