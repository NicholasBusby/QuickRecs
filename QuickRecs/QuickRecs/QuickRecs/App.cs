using Microsoft.Practices.Unity;
using QuickRecs.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace QuickRecs
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var button = new Button();
            button.Text = "button";
            var content = new ContentPage
            {
                Title = "QuickRecs",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "stuff"
                        },
                        button
                    }
                }
            };
            button.Clicked += Button_Clicked;

            MainPage = new NavigationPage(content);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            GetRecs();
        }

        public static UnityContainer DependancyContainer;

        protected override void OnStart()
        {
            Dependancy.Initialize();

        }

        private async void GetRecs()
        {
            var tasteKid = DependancyContainer.Resolve<TasteKid>();
            var result = await tasteKid.GetRecs("stuff");
            var things = result;
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
