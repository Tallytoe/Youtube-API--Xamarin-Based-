using Plugin.MediaManager;
using Plugin.MediaManager.Abstractions.Enums;
using Plugin.Share;
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
	public partial class Vplayer : ContentPage
    {
      //  private string videoUrl = "https://youtu.be/luDyX0kYzY4.mp4";
        public Vplayer()
        {
            InitializeComponent();
        }

        public Vplayer(string viid)
        {
            InitializeComponent();
          //lab.Text = viid;
            string abc = viid;
            CrossShare.Current.OpenBrowser("https://www.youtube.com/watch?v="+abc);
        }

      //  private string videoUrl = "https://www.youtube.com/watch?v=XAK89ARIm24.mp4";

      //  private void Button_Clicked(object sender, EventArgs e)
      //  {
          //  if (PlayStopButton.Text == "Play")
          //  {
             // CrossMediaManager.Current.Play(videoUrl, MediaFileType.Video);
          //      CrossShare.Current.OpenBrowser("https://www.youtube.com/watch?v=XAK89ARIm24");
          //      PlayStopButton.Text = "stop";
          //  }
          //  else if (PlayStopButton.Text == "Stop")
         //   {
           //     CrossMediaManager.Current.Stop();

           //     PlayStopButton.Text = "Play";
           // }
      //  }
    }
}

