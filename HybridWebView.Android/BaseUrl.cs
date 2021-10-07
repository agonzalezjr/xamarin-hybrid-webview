using HybridWebView.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl))]
namespace HybridWebView.Droid {
    public class BaseUrl : IBaseUrl {
        public string Get() {
            return "file:///android_asset/";
        }
    }
}

