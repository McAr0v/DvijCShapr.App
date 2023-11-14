using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform.Compatibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;

namespace DvijCShapr.Platforms.iOS
{
    public class MyShellRenderer : ShellRenderer
    {
        protected override IShellTabBarAppearanceTracker CreateTabBarAppearanceTracker()
        {
            var renderer = new MyCustomShellTabBarAppearanceTracker();
            return renderer;
        }
    }
    public class MyCustomShellTabBarAppearanceTracker : IShellTabBarAppearanceTracker
    {
        public MyCustomShellTabBarAppearanceTracker()
        {

        }

        public void Dispose()
        {

        }

        public void ResetAppearance(UITabBarController controller)
        {
        }

        public void SetAppearance(UITabBarController controller, ShellAppearance appearance)
        {
            if (UIDevice.CurrentDevice.CheckSystemVersion(13, 0))
            {
                UITabBarAppearance tabBarAppearance = (UITabBarAppearance)controller.TabBar.StandardAppearance.Copy();
                UITabBarItemAppearance itemAppearance = new UITabBarItemAppearance();
                var Font = UIFont.FromName("Test", 20);
                itemAppearance.Normal.TitleTextAttributes = new UIStringAttributes
                {// Font = UIFont.SystemFontOfSize(20)
                    Font = UIFont.FromName("Arial Bold Italic", 16)//you can set other fonts.

                };
                itemAppearance.Selected.TitleTextAttributes = new UIStringAttributes { .... };// selected style, you can set selected title color/font.
                tabBarAppearance.StackedLayoutAppearance = itemAppearance;
                controller.TabBar.StandardAppearance = tabBarAppearance;
            }
        }

        public void UpdateLayout(UITabBarController controller)
        {

        }
    }
}
