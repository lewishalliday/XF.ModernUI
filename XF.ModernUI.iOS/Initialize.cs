using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Xamarin.Forms.Platform.iOS;
using XF.ModernUI.Controls;

namespace XF.ModernUI
{
    [Preserve(AllMembers = true)]
    public static class Initialize
    {
#pragma warning disable 414
        private static List<PlatformEffect> _effects = new List<PlatformEffect>();
#pragma warning restore 414

        /// <summary>
        /// This is needed to ensure iOS loads the assembly with the effects in it
        /// </summary>
        public static void Init()
        {
            ModernEntryRenderer.Init();
        }
    }
}
