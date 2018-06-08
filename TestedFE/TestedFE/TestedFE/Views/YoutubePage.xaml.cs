using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestedFE.Models;
using TestedFE.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestedFE.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class YoutubePage : ContentPage
	{
		
     
        public void Hahahaha(object sender, EventArgs e)
        {
            
            string place = Mainsearch.Text;
            BindingContext = new YoutubeVM(place);
          //  YoutubeVM x = new YoutubeVM(place);
          // x.InitDataAsync(place);
        

        }

        public YoutubePage(string hk)
        {
            string koli = hk;
            BindingContext = new YoutubeVM(koli);
            InitializeComponent();
        }

        public YoutubePage()
        {

            // BindingContext = new YoutubeVM();
           
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var v = e.Item as YoutubeItem;
            string vid = v.VideoId;
            Navigation.PushAsync(new Vplayer(vid));

        }
    }
}