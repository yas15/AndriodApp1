using Android.App;
using Android.Widget;
using Android.OS;

namespace App2
{
    // An activity in an Android app represents a single screen with a user interface.
    // Setting MainLauncher = true, will cause this activity to be created,
    // when we launch the application i.e. this will be the first app screen.
    // Label = "First Android App":  Change the name of the app to "First Android App"
    // Update the App Icon to drawable/Robot_Pic.png
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
            // Resources /layout/Main.axml file, this button is called button1
            // To get Visual Studio to pickup the 'button1' we need to build the solution first.
            Button button = FindViewById<Button>(Resource.Id.button1);

            // add a delegate to the button click event
            button.Click += delegate { button.Text = string.Format("{0} Button clicked!", count++); };

        }
    }
}

