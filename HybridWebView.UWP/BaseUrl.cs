using HybridWebView.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl))]
namespace HybridWebView.UWP {
    public class BaseUrl : IBaseUrl {
        public string Get() {
            return "ms-appx-web:///";
        }
    }
}
