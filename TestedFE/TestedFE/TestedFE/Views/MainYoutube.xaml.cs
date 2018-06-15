using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestedFE.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestedFE.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainYoutube : ContentPage
	{
		public MainYoutube ()
		{
           // string h = "no";
          
           
            BindingContext =new YoutubeVMM();
			InitializeComponent ();
		}

        private void Mainsearch_SearchButtonPressedd(object sender, EventArgs e)
        {
            string place = Mainsearch1.Text;
            Navigation.PushAsync(new YoutubePage(place));
        }

      
        private void Button_Clicked(object sender, EventArgs e)
        {
            string place = "trending";
            Navigation.PushAsync(new YoutubePage(place));
        }
    }
}