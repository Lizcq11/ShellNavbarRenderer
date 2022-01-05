using AppShellRenderer;
using AppShellRenderer.iOS.Renderers;
using Foundation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(AppShell),typeof(ShellNavbarRenderer))]
namespace AppShellRenderer.iOS.Renderers
{
    public class ShellNavbarRenderer :ShellRenderer
    {
        protected override void OnElementPropertyChanged(object sender,PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender,e);
        }

        protected override IShellNavBarAppearanceTracker CreateNavBarAppearanceTracker()
        {
            return new CustomNavbarGradient();
        }
    }
}