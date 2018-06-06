using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestedFE.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainYoutube : ContentPage
	{
		public MainYoutube ()
		{
			InitializeComponent ();
		}

        private void Mainsearch_SearchButtonPressedd(object sender, EventArgs e)
        {
            //string place = Mainsearch.Text;
           // Navigation.PushAsync(new YoutubePage(place));
        }
    }
}