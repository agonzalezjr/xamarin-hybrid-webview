using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HybridWebView {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();

            // webView.Source = "https://www.google.com";

            var htmlSource = new HtmlWebViewSource();
            htmlSource.BaseUrl = DependencyService.Get<IBaseUrl>().Get();

            string html = @"
<html>
<head>
    <title>Xamarin Forms</title>
</head>
<body>
    <script src=""http://code.jquery.com/jquery-2.1.4.min.js""></script>
    <h1>Xamarin.Forms</h1>
    <pre id=""location"">Location: </pre>
    <button onclick=""javascript: $('#location').text('Location: ' + window.location.href);"">Show window.location.href</button>
</body>
</html>
";
            htmlSource.Html = html;

            webView.Source = htmlSource;
        }
    }
}
