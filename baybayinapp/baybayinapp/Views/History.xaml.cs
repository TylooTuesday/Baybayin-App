using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace baybayinapp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class History : ContentPage
    {
        public History()
        {
            InitializeComponent();
        }
        private async void GotoLink(object sender, EventArgs e)
        {
            await Browser.OpenAsync("http://baybayinalive.com/the-baybayin-musings-on-a-forgotten-history-by-john-paul-lakan-olivares/#:~:text=The%20Baybayin%3A%20Musings%20on%20a%20Forgotten%20History%20In,with%20the%20root%20word%20%E2%80%9Cbaybay%E2%80%9D%20or%20%E2%80%98to%20spell%E2%80%99.", BrowserLaunchMode.SystemPreferred);
        }
    }
}