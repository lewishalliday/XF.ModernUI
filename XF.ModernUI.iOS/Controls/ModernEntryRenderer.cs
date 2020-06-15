using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XF.ModernUI.Controls;
using XF.ModernUI.Forms;
using CoreGraphics;

[assembly: ExportRenderer(typeof(ModernEntry), typeof(ModernEntryRenderer))]
namespace XF.ModernUI.Controls
{
    public class ModernEntryRenderer : EntryRenderer
    {
        public static void Init()
        { }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            BackgroundColor = UIColor.Red;
            ClipsToBounds = false;
            Layer.CornerRadius = 8;

            Layer.BorderWidth = 0;
            Layer.BorderColor = UIColor.White.CGColor;

            Layer.ShadowOpacity = 1;
            Layer.ShadowRadius = 30;
            Layer.ShadowOffset = new CGSize(2.0, 2.0);
            Layer.ShadowColor = UIColor.Gray.CGColor;
        }
    }
}

