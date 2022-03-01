using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinFormsControls.CustomRenderersAll;
using XamarinFormsControls.Droid.CustomRenders;

[assembly: ExportRenderer(typeof(CustomButton),typeof(CustomButtonRenderer))]           //Kod içinde yazılan Control.SetAllCaps(false); in assebly olarak belirtmem gerekiyor. Sen bir exportrenderer sın, handle ve target diye 2 paramerte alır; ilki zamarinforms butonundan kalıttığım custombuton buna ulaş sonra CustomButtonRenderer'ı yerine koy. 

namespace XamarinFormsControls.Droid.CustomRenders
{
    [Obsolete]
    public class CustomButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)       //override OnElementChanged yazınca aşağıda gelenden geç
        {
            base.OnElementChanged(e);

            if (Control != null)   
            {
                Control.SetAllCaps(false);      //Haflerin herzaman büyük olmasını kapattık.
                Control.SetBackgroundColor(Android.Graphics.Color.Red);     //Defaultta rengini set ettik. 

            }
        }
    }
}