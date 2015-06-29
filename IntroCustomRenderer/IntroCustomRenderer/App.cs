using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace IntroCustomRenderer
{
    public class App : Application
    {
        public App()
        {

            var tb = new CustomTabbedPage()
            {
            };

            tb.Children.Add(new ContentPage()
            {
                Title = "Vermelho",
                Content = new StackLayout()
                {
                    BackgroundColor = Color.Red
                },
                Icon = "edit.png"
            });
            tb.Children.Add(new ContentPage()
            {
                Title = "Azul",
                Content = new StackLayout()
                {
                    BackgroundColor = Color.Blue
                },
                Icon = "add.png"
            });
            tb.Children.Add(new ContentPage()
            {
                Title = "Verde",
                Content = new StackLayout()
                {
                    BackgroundColor = Color.Green
                },
                Icon = "search.png"
            });
            // The root page of your application
            MainPage = tb;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
