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
    [Activity(Label = "SorteoCuatro")]
    public class SorteoCuatro : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Sort4);

            var view0 = FindViewById<TextView>(Resource.Id.zero);

            var view1 = FindViewById<TextView>(Resource.Id.one);
            var n1 = FindViewById<NumberPicker>(Resource.Id.N_uno);

            n1.MinValue = 1;
            n1.MaxValue = 52;

            n1.ValueChanged += (sender, args) =>
            {
                view1.Text = args.NewVal.ToString();
            };

            var view2 = FindViewById<TextView>(Resource.Id.two);
            var n2 = FindViewById<NumberPicker>(Resource.Id.N_dos);

            n2.MinValue = 1;
            n2.MaxValue = 52;

            n2.ValueChanged += (sender, args) =>
            {
                view2.Text = args.NewVal.ToString();
            };

            var view3 = FindViewById<TextView>(Resource.Id.three);
            var n3 = FindViewById<NumberPicker>(Resource.Id.N_tres);

            n3.MinValue = 1;
            n3.MaxValue = 52;

            n3.ValueChanged += (sender, args) =>
            {
                view3.Text = args.NewVal.ToString();
            };

            var view4 = FindViewById<TextView>(Resource.Id.four);
            var n4 = FindViewById<NumberPicker>(Resource.Id.N_cuatro);

            n4.MinValue = 1;
            n4.MaxValue = 52;

            n4.ValueChanged += (sender, args) =>
            {
                view4.Text = args.NewVal.ToString();
            };

            var view5 = FindViewById<TextView>(Resource.Id.five);
            var n5 = FindViewById<NumberPicker>(Resource.Id.N_cinco);

            n5.MinValue = 1;
            n5.MaxValue = 52;

            n5.ValueChanged += (sender, args) =>
            {
                view5.Text = args.NewVal.ToString();
            };

            Button confirm_btn = FindViewById<Button>(Resource.Id.confirm);

            confirm_btn.Click += (sender, args) =>
            {
                string one, two, three, four, five, result;
                one = n1.Value.ToString();
                two = n2.Value.ToString();
                three = n3.Value.ToString();
                four = n4.Value.ToString();
                five = n5.Value.ToString();
                result = one + two + three + four + five;
                Intent intent = new Intent(this, typeof(Numbers));
                intent.PutExtra("confirmacion", result);
                StartActivity(intent);
                Finish();
            };
        }
    }
}