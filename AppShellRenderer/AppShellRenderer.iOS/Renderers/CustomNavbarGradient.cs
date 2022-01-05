using CoreAnimation;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace AppShellRenderer.iOS.Renderers
{
    public class CustomNavbarGradient : IShellNavBarAppearanceTracker
    {
        public void Dispose()
        {
        }

        public void ResetAppearance(UINavigationController controller)
        {
        }

        public void SetAppearance(UINavigationController controller,ShellAppearance appearance)
        {
            CAGradientLayer gradient = new CAGradientLayer();
            gradient.Frame = controller.NavigationBar.Bounds;
            gradient.Colors = new CoreGraphics.CGColor[] { new UIColor(red: 0.09f,green: 0.83f,blue: 0.92f,alpha: 1.00f).CGColor,new UIColor(red: 0.00f,green: 0.18f,blue: 0.55f,alpha: 1.00f).CGColor };
            gradient.StartPoint = new CoreGraphics.CGPoint(0,0);
            gradient.EndPoint = new CoreGraphics.CGPoint(1,0);
            controller.NavigationBar.SetBackgroundImage(ImageFromLayer(gradient),UIBarMetrics.Default);
            controller.NavigationBar.TintColor = UIColor.White;
        }
        public void SetHasShadow(UINavigationController controller,bool hasShadow)
        {
        }

        public void UpdateLayout(UINavigationController controller)
        {
        }

        private UIImage ImageFromLayer(CALayer layer)
        {
            UIGraphics.BeginImageContext(layer.Frame.Size);
            layer.RenderInContext(UIGraphics.GetCurrentContext());
            UIImage outputImage = UIGraphics.GetImageFromCurrentImageContext();
            UIGraphics.EndImageContext();
            return outputImage;
        }
    }
}