﻿using System;
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

        public YoutubePage()
        {

            // BindingContext = new YoutubeVM();
           
            InitializeComponent();
        }
    }
}