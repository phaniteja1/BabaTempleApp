using Android.App;
using Android.Widget;
using Android.OS;

namespace BabaTempleAppAndroid
{
	[Activity (Label = "BabaTempleApp", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

            // Set our view from the "main" layout resource
            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            SetContentView (Resource.Layout.Main);

            ActionBar.Tab tab = ActionBar.NewTab();
    tab.SetText("Hello");
            tab.SetIcon(Resource.Drawable.Icon);
            tab.TabSelected += (sender, args) => {
                // Do something when tab is selected
            };

            ActionBar.AddTab(tab);

    tab = ActionBar.NewTab();
    tab.SetText("About");
         tab.SetIcon(Resource.Drawable.Icon);
            tab.TabSelected += (sender, args) =>
            {
                // Do something when tab is selected
            };
    ActionBar.AddTab(tab);

			// Get our button from the layout resource,
			// and attach an event to it
			
		}
	}
}


