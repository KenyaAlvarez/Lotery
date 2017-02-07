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

            TextView numb = FindViewById<TextView>(Resource.Id.numeros);
            numb.Text = Intent.GetStringExtra("Confirmation");

            Button yes = FindViewById<Button>(Resource.Id.si);

            Button No = FindViewById<Button>(Resource.Id.no);

        }

        private void OnNoAnswered(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(SorteoUno));
            StartActivity(intent);
            Finish();
        }

        private void OnYesAnswered(object sender, EventArgs e)
        {
            Finish();
        }


    }

}

