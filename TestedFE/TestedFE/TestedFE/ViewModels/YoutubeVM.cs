using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TestedFE.Models;
using Xamarin.Forms;
using TestedFE.Views;


namespace TestedFE.ViewModels
{
    class YoutubeVM : INotifyPropertyChanged

    {

        private HttpClient cclient = new HttpClient();

        private const string ApiKey = "AIzaSyBtc8gM2Aped4tzkIw_avG8xtTRXSAaAXQ";

       // private string apiUrlForVideosDetails = "https://www.googleapis.com/youtube/v3/search?part=snippet&q=spongebob&maxResults=20&order=rating" + "&key=" + ApiKey;

        private List<YoutubeItem> _youtubeItems;

        public List<YoutubeItem> YoutubeItems
        {
            get
            {
                Debug.WriteLine("Getting get");
                return _youtubeItems;

            }
            set
            {
                Debug.WriteLine("Setting set");
                _youtubeItems = value;
                OnPropertyChanged();
            }
        }

       

        public YoutubeVM(string hk)
        {
            InitDataAsync(hk);
        }
       
        public async Task InitDataAsync(string xh) 
        {

            YoutubeItems = await GetVideosAsync(xh);

            Debug.WriteLine("Init done done");
          


        }

        private async Task<List<YoutubeItem>> GetVideosAsync(string xxh)
        {
            string apiUrlForVideosDetails = "https://www.googleapis.com/youtube/v3/search?part=snippet&q=" +xxh+ "&maxResults=50&order=rating" + "&key=" + ApiKey;
            var content = await cclient.GetStringAsync(apiUrlForVideosDetails);

            Debug.WriteLine("async started");
            
            var youtubeItems = new List<YoutubeItem>();
            Debug.WriteLine("B4 tryblock"+xxh);
            try
            {
                Debug.WriteLine("Tryblock");
                Debug.WriteLine(content);
                JObject response = JsonConvert.DeserializeObject<dynamic>(content);
                Debug.WriteLine(response);

                var items = response.Value<JArray>("items");
                Debug.WriteLine(items);
                Debug.WriteLine("B4 for each items");
                foreach (var checki in items)
                {
                    var snippet = checki.Value<JObject>("snippet");
                    var id = checki.Value<JObject>("id");
                    Debug.WriteLine(snippet);
                    Debug.WriteLine(id);

                    var h = new YoutubeItem
                    {
                        VideoId = id.Value<string>("videoId"),
                        Title = snippet.Value<string>("title"),
                        DefaultThumbnailUrl = snippet?.Value<JObject>("thumbnails")?.Value<JObject>("default")?.Value<string>("url"),
                        MediumThumbnailUrl = snippet?.Value<JObject>("thumbnails")?.Value<JObject>("medium")?.Value<string>("url"),
                        HighThumbnailUrl = snippet?.Value<JObject>("thumbnails")?.Value<JObject>("high")?.Value<string>("url"),


                    };

                    Debug.WriteLine(h.VideoId + " cheez value");
                    Debug.WriteLine(h.Title + " cheez value");
                    Debug.WriteLine(h.DefaultThumbnailUrl);
                    Debug.WriteLine(h.HighThumbnailUrl);
                    Debug.WriteLine("****************************************");

                    youtubeItems.Add(h);

                }
                foreach (var a in youtubeItems)
                {
                    Debug.WriteLine(a);
                    Debug.WriteLine("*********XXXXX**************");
                }
                Debug.WriteLine("return Utubeitem");
                return youtubeItems;
            }
            catch (Exception exception)
            {
                return youtubeItems;
                Debug.WriteLine("Exception");
            }

        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

