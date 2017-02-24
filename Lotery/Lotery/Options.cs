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

            Button buton = FindViewById<Button>(Resource.Id.button_LNacional);
            buton.Click += delegate
            {
                StartActivity(typeof(MainSort));
            };

            Button butn = FindViewById<Button>(Resource.Id.button_pronosticos);
            butn.Click += delegate
            {
                StartActivity(typeof(SecondSort));
            };
        }
    }
}