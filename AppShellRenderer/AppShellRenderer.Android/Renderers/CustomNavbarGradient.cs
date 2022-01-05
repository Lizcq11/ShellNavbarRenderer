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

namespace AppShellRenderer.Droid.Renderers
{
    public class CustomNavbarGradient : IShellToolbarAppearanceTracker
    {
        public void Dispose()
        {
        }

        public void ResetAppearance(AndroidX.AppCompat.Widget.Toolbar toolbar,IShellToolbarTracker toolbarTracker)
        {
        }

        public void SetAppearance(AndroidX.AppCompat.Widget.Toolbar toolbar,IShellToolbarTracker toolbarTracker,ShellAppearance appearance)
        {
            toolbar.SetBackgroundResource(Resource.Drawable.custom_gradient);
        }
    }
}