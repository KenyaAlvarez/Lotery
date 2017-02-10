using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Lotery
{
    [Activity(Label = "SorteoUno")]
    public class MainSort : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.Menu);

            Button boton = FindViewById<Button>(Resource.Id.btn);
            boton.Click += delegate
            {
                StartActivity(typeof(SorteoUno));
            };

            Button botonuno = FindViewById<Button>(Resource.Id.btnL2);
            botonuno.Click += delegate
            {
                StartActivity(typeof(SorteoDos));
            };

            Button botondos = FindViewById<Button>(Resource.Id.btnL3);
            {
                StartActivity(typeof(SorteoTres));
            };
        }
    }
}