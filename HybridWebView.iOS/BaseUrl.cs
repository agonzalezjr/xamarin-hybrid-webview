using HybridWebView.iOS;
using Foundation;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl))]
namespace HybridWebView.iOS {
    public class BaseUrl : IBaseUrl {
        public string Get() {
            return NSBundle.MainBundle.BundlePath;
        }
    }
}
