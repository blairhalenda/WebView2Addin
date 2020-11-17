using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace WebView2Addin
{
    public partial class CustomTaskPane : UserControl
    {
        public CustomTaskPane()
        {
            InitializeComponent();
            InitializeWebEnv();
        }



        public async void InitializeWebEnv()
        {
            
            string dir = @"C:\temp\WebView2Addin";
            string url = @"https://this-page-intentionally-left-blank.org/";

            try
            {
                CoreWebView2Environment env = await CoreWebView2Environment.CreateAsync(null, dir);
                await webView.EnsureCoreWebView2Async(env);
                webView.CoreWebView2.Navigate(url);
                webView.CoreWebView2.Settings.IsZoomControlEnabled = false;
                webView.ZoomFactor = 1;

            }
            catch (Exception exception)
            {
                throw exception;
            }

            return;
        }
    }
}
