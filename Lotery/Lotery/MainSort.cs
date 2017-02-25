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
    [Activity(Label = "Loteria Nacional")]
    public class MainSort : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.Menu);

            TextView title = FindViewById<TextView>(Resource.Id.menu);
            title.Text = "Welcome " + Intent.GetStringExtra("username");

            Button button_one = FindViewById<Button>(Resource.Id.btn_1);
            Button button_two = FindViewById<Button>(Resource.Id.btn_2);
            Button button_three = FindViewById<Button>(Resource.Id.btn_3);

            button_one.Click += SorteoUno_selected;
            button_two.Click += SorteoTwo_selected;
            button_three.Click += SorteoTree_selected;
        }

        private void SorteoUno_selected(object sender, EventArgs e)
        {
            var myIntent = new Intent(this, typeof(SorteoUno));
            StartActivityForResult(myIntent, 0);
        }

        private void SorteoTwo_selected(object sender, EventArgs e)
        {
            var myIntent = new Intent(this, typeof(SorteoDos));
            StartActivityForResult(myIntent, 0);
        }

        private void SorteoTree_selected(object sender, EventArgs e)
        {
            var myIntent = new Intent(this, typeof(SorteoTres));
            StartActivityForResult(myIntent, 0);
        }
    }
}
