using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppShellRenderer;
using AppShellRenderer.Droid.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(AppShell),typeof(ShellNavbarRenderer))]

namespace AppShellRenderer.Droid.Renderers
{
    public class ShellNavbarRenderer : ShellRenderer
    {
        public ShellNavbarRenderer(Context context) : base(context)
        {

        }

        protected override IShellToolbarAppearanceTracker CreateToolbarAppearanceTracker()
        {
            return new CustomNavbarGradient();
        }
    }
}