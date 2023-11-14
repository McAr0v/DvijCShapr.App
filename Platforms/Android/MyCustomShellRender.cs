using Android.Text.Style;
using Android.Text;
using Android.Views;
using Google.Android.Material.BottomNavigation;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform.Compatibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvijCShapr.Platforms.Android
{
    public class MyCustomShellRender : ShellRenderer
    {
        protected override IShellBottomNavViewAppearanceTracker CreateBottomNavViewAppearanceTracker(ShellItem shellItem)
        {
            return new MyBottomNavigationView();
        }
    }
    public class MyBottomNavigationView : IShellBottomNavViewAppearanceTracker
    {
        public MyBottomNavigationView()
        {

        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
        public void ResetAppearance(BottomNavigationView bottomView)
        {

        }
        public void SetAppearance(BottomNavigationView bottomView, IShellAppearanceElement appearance)
        {
            IMenu menu = bottomView.Menu;
            for (int i = 0; i < bottomView.Menu.Size(); i++)
            {
                IMenuItem menuItem = menu.GetItem(i);
                var title = menuItem.TitleFormatted;
                SpannableStringBuilder sb = new SpannableStringBuilder(title);
                sb.SetSpan(new TypefaceSpan("serif"), 0, sb.Length(), SpanTypes.InclusiveInclusive);//serif, you can set other fonts.
                
                menuItem.SetTitle(sb);
            }
        }
    }
}
