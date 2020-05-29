using System;
using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XF.ModernUI.Controls;
using XF.ModernUI.Forms;

[assembly: ExportRenderer(typeof(ModernEntry), typeof(ModernEntryRenderer))]
namespace XF.ModernUI.Controls
{
    public class ModernEntryRenderer : EntryRenderer
    {
        public ModernEntryRenderer(Context context) : base(context)
        {
        }
    }
}
