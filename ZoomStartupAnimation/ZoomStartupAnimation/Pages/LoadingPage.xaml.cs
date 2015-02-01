using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace ZoomStartupAnimation
{
    public partial class LoadingPage : ContentPage
    {
        public LoadingPage()
        {
            InitializeComponent();

            Initialize();
        }

        async void Initialize()
        {
            await ExecuteStoryboardAsync();
            await this.Navigation.PushAsync(new MainPage());
        }

        async Task ExecuteStoryboardAsync()
        {
            await Task.Delay(3000);
            await LogoImage.ScaleTo(0.75f, length: 1000, easing: Easing.CubicOut);
            await LogoImage.ScaleTo(25, length: 250, easing: Easing.CubicIn);
        }
    }
}

