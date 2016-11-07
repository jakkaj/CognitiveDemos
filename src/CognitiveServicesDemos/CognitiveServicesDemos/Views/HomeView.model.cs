using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using CognitiveServicesDemos.Model.App;

namespace CognitiveServicesDemos.Views
{
    public class HomeViewModel : ViewModel
    {
        public List<HomeViewItem> HomeViews { get; set; }
        public HomeViewModel()
        {
            HomeViews = new List<HomeViewItem>()
            {
                new HomeViewItem
                {
                    Title = "Vision", 
                    SubText = "From faces to feelings, allow your apps to understand images and video", 
                    Image = "/CognitiveServicesDemos;component/Assets/Picture1.png"
                },
                 new HomeViewItem
                {
                    Title = "Speech",
                    SubText = "Hear and speak to your users by filtering noise, identifying speakers, and understanding intent",
                    Image = "/CognitiveServicesDemos;component/Assets/Picture2.png"
                },
                  new HomeViewItem
                {
                    Title = "Vision",
                    SubText = "From faces to feelings, allow your apps to understand images and video",
                    Image = "/CognitiveServicesDemos;component/Assets/Picture3.png"
                }
            };
        }
    }

    public class HomeViewItem
    {
        public string Title { get; set; }
        public string SubText { get; set; }
        public string Image { get; set; }
        public Page Page { get; set; }
    }
}
