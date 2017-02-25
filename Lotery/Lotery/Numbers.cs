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
    [Activity(Label = "Numbers")]
    public class Numbers : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.Comprobacion);

            TextView tittle = FindViewById<TextView>(Resource.Id.numeros);
            tittle.Text = Intent.GetStringExtra ("confirmacion");
            Button yes = FindViewById<Button>(Resource.Id.si);
            Button No = FindViewById<Button>(Resource.Id.no);

            yes.Click += OnYesAnswered;
            No.Click += OnnoAnswered;

    }

        private void OnnoAnswered(object sender, EventArgs e)
        {
            Finish();
        }

        private void OnYesAnswered(object sender, EventArgs e)
        {
            string no_ticky = FindViewById<TextView>(Resource.Id.numeros).Text;
            Intent intent = new Intent(this, typeof(Ticket));
            intent.PutExtra("n_to_ticket", no_ticky);
            StartActivityForResult(intent,0);
            Finish();
        }


    }

}

