using System;
using System.ComponentModel;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XF.ModernUI.Controls;
using XF.ModernUI.Forms;

[assembly: ExportRenderer(typeof(ModernButton), typeof(ModernButtonRenderer))]
namespace XF.ModernUI.Controls
{
    public class ModernButtonRenderer : ButtonRenderer
    {
        private ModernButton ParentData => (ModernButton)Element;


        public static void Init()
        { }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            SetupUI();
            AddAnimations();
        }

        private void SetupUI()
        {
            BackgroundColor = ParentData.BackgroundColor.ToUIColor();
            ClipsToBounds = false;
            Layer.CornerRadius = ParentData.CornerRadius;
            Layer.BorderWidth = 0;
            if (ParentData.HasShadow)
            {
                Layer.ShadowOpacity = ParentData.ShadowOpacity;
                Layer.ShadowRadius = ParentData.ShadowRadius;
                Layer.ShadowOffset = new CGSize(2.0, 2.0);
                Layer.ShadowColor = ParentData.BackgroundColor.ToCGColor();
            }
        }

        private void AddAnimations()
        {
            if (ParentData.HasShadow)
            {
                Control.TouchDown += delegate
                {
                    var animation = CABasicAnimation.FromKeyPath("shadowOpacity");
                    animation.To = NSNumber.FromFloat(0.0f);
                    animation.Duration = 0.2;
                    animation.RemovedOnCompletion = false;
                    animation.FillMode = CAFillMode.Forwards;
                    Layer.AddAnimation(animation, animation.KeyPath);
                };
                Control.TouchUpInside += delegate
                {
                    var animation = CABasicAnimation.FromKeyPath("shadowOpacity");
                    animation.From = NSNumber.FromFloat(0.0f);
                    animation.To = NSNumber.FromFloat(ParentData.ShadowOpacity);
                    animation.Duration = 0.2;
                    animation.RemovedOnCompletion = false;
                    animation.FillMode = CAFillMode.Forwards;
                    Layer.AddAnimation(animation, animation.KeyPath);
                };
            }
        }
    }
}
