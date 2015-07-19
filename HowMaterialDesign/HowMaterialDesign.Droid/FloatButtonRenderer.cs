using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using HowMaterialDesign;
using HowMaterialDesign.Droid;
using Xamarin.Forms.Platform.Android;
using Android.Support.Design.Widget;


[assembly: ExportRenderer(typeof(FloatButton), typeof(FloatButtonRenderer))]
namespace HowMaterialDesign.Droid
{
    public class FloatButtonRenderer : ViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e)
        {
            base.OnElementChanged(e);

            var FAB = new FloatingActionButton(this.Context);

            
			FAB.SetImageResource(Resource.Drawable.ic_add);

            SetNativeControl(FAB);
        }
    }
}