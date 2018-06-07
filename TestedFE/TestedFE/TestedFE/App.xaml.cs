using System;
using TestedFE.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace TestedFE
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            //MainPage = new YoutubePage();
            MainPage = new NavigationPage(new MainYoutube());
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
