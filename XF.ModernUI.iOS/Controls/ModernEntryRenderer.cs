using System;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XF.ModernUI.Controls;
using XF.ModernUI.Forms;

[assembly: ExportRenderer(typeof(ModernEntry), typeof(ModernEntryRenderer))]
namespace XF.ModernUI.Controls
{
    public class ModernEntryRenderer : EntryRenderer
    {
        public ModernEntryRenderer()
        {
        }
    }
}

