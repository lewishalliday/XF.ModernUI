using System;
using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XF.ModernUI.Controls;
using XF.ModernUI.Forms;

[assembly: ExportRenderer(typeof(ModernButton), typeof(ModernButtonRenderer))]
namespace XF.ModernUI.Controls
{
    public class ModernButtonRenderer : ButtonRenderer
    {
        public ModernButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            //Control.Elevation = 1;
            Control.SetShadowLayer(10, 2, 2, Android.Graphics.Color.Green);
        }
    }
}
