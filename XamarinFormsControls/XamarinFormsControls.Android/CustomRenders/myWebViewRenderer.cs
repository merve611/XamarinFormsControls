using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinFormsControls.CustomRenderersAll;
using XamarinFormsControls.Droid.CustomRenders;

[assembly: ExportRenderer(typeof(myWebView), typeof(myWebViewRenderer))]
namespace XamarinFormsControls.Droid.CustomRenders
{
    public class myWebViewRenderer : WebViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null || Element == null)
            {
                return;
            }
            var element = Element as myWebView;
            Control.Settings.TextZoom = element.ZoomInLevel;
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (Control != null)
            {
                Control.Settings.BuiltInZoomControls = true;

                //to show the default zoom controls, if you want to use your own button, set this property to false.
                Control.Settings.DisplayZoomControls = true;
                Control.Settings.LoadWithOverviewMode = true;
                Control.Settings.UseWideViewPort = true;
            }

            var element = Element as myWebView;
            Control.Settings.TextZoom = element.ZoomInLevel;

            base.OnElementPropertyChanged(sender, e);
        }
    }
}