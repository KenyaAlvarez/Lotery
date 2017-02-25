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
    [Activity(Label = "Pronosticos")]
    public class SecondSort : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Menu_Pronosticos);

            Button button_four = FindViewById<Button>(Resource.Id.btn_4);
            Button button_five = FindViewById<Button>(Resource.Id.btn_5);
            Button button_six = FindViewById<Button>(Resource.Id.btn_6);

            button_four.Click += SorteoFour_selected;
            button_five.Click += SorteoFive_selected;
            button_six.Click += SorteoSix_selected;
        }

        private void SorteoFour_selected(object sender, EventArgs e)
        {
            var myIntent = new Intent(this, typeof(SorteoCuatro));
            StartActivityForResult(myIntent, 0);
        }

        private void SorteoFive_selected(object sender, EventArgs e)
        {
            var myIntent = new Intent(this, typeof(SorteoCinco));
            StartActivityForResult(myIntent, 0);
        }

        private void SorteoSix_selected(object sender, EventArgs e)
        {
            var myIntent = new Intent(this, typeof(SorteoSeis));
            StartActivityForResult(myIntent, 0);
        }
    }
}