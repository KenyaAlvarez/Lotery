                using Android.App;
using Android.Widget;
using Android.OS;

namespace Lotery
{
    [Activity(Label = "Lotery", MainLauncher = true, Icon = "@drawable/icon")]
    public class Options : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Inicio);

            Button buton = FindViewById<Button>(Resource.Id.button1);
            buton.Click += delegate
            {
                StartActivity(typeof(MainSort));
            };

            Button butn = FindViewById<Button>(Resource.Id.button2);
            butn.Click += delegate
            {
                StartActivity(typeof(MainSort));
            };

        } 
    }
}

