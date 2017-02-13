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

            TextView title = FindViewById<TextView>(Resource.Id.menu);
            title.Text = "Welcome " + Intent.GetStringExtra("username");

            Button boton = FindViewById<Button>(Resource.Id.btn);
            Button botton = FindViewById<Button>(Resource.Id.btnL2);
            Button Buton = FindViewById<Button>(Resource.Id.btnL3);

            boton.Click += SorteoUno_selected;
            botton.Click += SorteoUno_selected;
            Buton.Click += SorteoUno_selected;
        }

        private void SorteoUno_selected(object sender, EventArgs e)
        {
            var myIntent = new Intent(this, typeof(SorteoUno));
            StartActivityForResult(myIntent, 0);
        }
    }
    }
