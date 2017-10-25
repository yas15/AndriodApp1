using Android.App;
using Android.Widget;
using Android.OS;

namespace App2
{
    [Activity(Label = "First Android App", MainLauncher = true, Icon = "@drawable/Robot_Pic")]
    public class MainActivity : Activity
    {
        int count = 1; 
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            // We have added a button using the toolbox to the 
            // Resources /layput/Main.axml file, this button is called button1
            // To get Visual Studio to pickup the 'button1' we need to build the solution first.
            Button button = FindViewById<Button>(Resource.Id.button1);

            // add a delegate to the button click event
            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

        }
    }
}

