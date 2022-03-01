using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinFormsControls.CustomRenderersAll
{
   
        public class myWebView : WebView
        {
            public int ZoomInLevel
            {
                get { return (int)GetValue(ZoomInLevelProperty); }
                set { SetValue(ZoomInLevelProperty, value); }
            }

        
            public static readonly BindableProperty ZoomInLevelProperty =
                BindableProperty.Create(propertyName: "ZoomInLevel",
                    returnType: typeof(int),
                    declaringType: typeof(myWebView),
                    defaultValue: 3,
                    propertyChanged: OnZoomInLevelPropertyChanged);

            private static void OnZoomInLevelPropertyChanged(BindableObject bindable, object oldValue, object newValue)
            {

            }
        }
    
}
