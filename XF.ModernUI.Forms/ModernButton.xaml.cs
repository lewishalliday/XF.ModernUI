using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XF.ModernUI.Forms
{
    public partial class ModernButton : Button
    {
        /// <summary>
        /// Set the button background color. Default = White
        /// </summary>
        public static new readonly BindableProperty BackgroundColorProperty
            = BindableProperty.Create(nameof(BackgroundColor), typeof(Color), typeof(ModernButton), Color.White);

        public new Color BackgroundColor
        {
            get { return (Color)GetValue(BackgroundColorProperty); }
            set { SetValue(BackgroundColorProperty, value); }
        }

        /// <summary>
        /// Set the button corner radius. Default = 8
        /// </summary>
        public static new readonly BindableProperty CornerRadiusProperty
            = BindableProperty.Create(nameof(CornerRadius), typeof(int), typeof(ModernButton), 8);

        public new int CornerRadius
        {
            get { return (int)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        /// <summary>
        /// Set if the button has a shadow. Default = True
        /// </summary>
        public static readonly BindableProperty HasShadowProperty
            = BindableProperty.Create(nameof(HasShadow), typeof(bool), typeof(ModernButton), true);

        public bool HasShadow
        {
            get { return (bool)GetValue(HasShadowProperty); }
            set { SetValue(HasShadowProperty, value); }
        }

        /// <summary>
        /// Set the opacity of the button shadow. Default = 0.6
        /// </summary>
        public static readonly BindableProperty ShadoOpacityProperty
            = BindableProperty.Create(nameof(ShadowOpacity), typeof(float), typeof(ModernButton), 0.6f);

        public float ShadowOpacity
        {
            get { return (float)GetValue(ShadoOpacityProperty); }
            set { SetValue(ShadoOpacityProperty, value); }
        }

        /// <summary>
        /// Set the radius of the button shadow. Default = 10
        /// </summary>
        public static readonly BindableProperty ShadowRadiusProperty
            = BindableProperty.Create(nameof(ShadowRadius), typeof(int), typeof(ModernButton), 10);

        public int ShadowRadius
        {
            get { return (int)GetValue(ShadowRadiusProperty); }
            set { SetValue(ShadowRadiusProperty, value); }
        }


        public ModernButton()
        {
            InitializeComponent();
        }
    }
}
