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
    [Activity(Label = "Loggin")]
    public class Loggin : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Sesion);

            TextView user = FindViewById<TextView>(Resource.Id.usuario);
            TextView password = FindViewById<TextView>(Resource.Id.pass);

            Button btn = FindViewById<Button>(Resource.Id.access);
            btn.Click += delegate
            {
                StartActivity(typeof(Options));
            };
        }

    }
    }
