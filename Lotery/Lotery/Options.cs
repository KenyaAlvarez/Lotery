using Android.App;
using Android.Widget;
using Android.OS;

namespace Lotery
{
    [Activity(Label = "Loteria")]
    public class Options : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Inicio);

            Button button = FindViewById<Button>(Resource.Id.button_LNacional);
            Button button2 = FindViewById<Button>(Resource.Id.button_pronosticos);

            button.Click += delegate
            {
                StartActivity(typeof(MainSort));
            };

            button2.Click += delegate
            {
                StartActivity(typeof(SecondSort));
            };
        }
    }
}