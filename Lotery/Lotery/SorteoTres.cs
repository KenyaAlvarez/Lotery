
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
    [Activity(Label = "SorteoTres")]
    public class SorteoTres : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Sort1);

            NumberPicker Picker = FindViewById<NumberPicker>(Resource.Id.pickeruno);
            TextView n_one = FindViewById<TextView>(Resource.Id.text_1);
            Picker.MinValue = 1;
            Picker.MaxValue = 52;

            Picker.ValueChanged += (sender, args) =>
            {
                n_one.Text = args.NewVal.ToString();
            };

            NumberPicker picker = FindViewById<NumberPicker>(Resource.Id.pickerdos);
            TextView n_two = FindViewById<TextView>(Resource.Id.text_2);
            picker.MinValue = 1;
            picker.MaxValue = 52;

            picker.ValueChanged += (sender, args) =>
            {
                n_two.Text = args.NewVal.ToString();
            };

            NumberPicker numpicker = FindViewById<NumberPicker>(Resource.Id.pickertres);
            TextView n_three = FindViewById<TextView>(Resource.Id.text_3);
            numpicker.MinValue = 1;
            numpicker.MaxValue = 52;

            numpicker.ValueChanged += (sender, args) =>
            {
                n_three.Text = args.NewVal.ToString();
            };

            NumberPicker picker4 = FindViewById<NumberPicker>(Resource.Id.pickercuatro);
            TextView n_for = FindViewById<TextView>(Resource.Id.text_4);
            picker4.MinValue = 1;
            picker4.MaxValue = 52;

            picker4.ValueChanged += (sender, args) =>
            {
                n_for.Text = args.NewVal.ToString();
            };

            NumberPicker picker5 = FindViewById<NumberPicker>(Resource.Id.pickercinco);
            TextView n_five = FindViewById<TextView>(Resource.Id.text_5);
            picker5.MinValue = 1;
            picker5.MaxValue = 52;

            picker5.ValueChanged += (sender, args) =>
            {
                n_five.Text = args.NewVal.ToString();
            };


            Button confirm_btn = FindViewById<Button>(Resource.Id.confirm);

            confirm_btn.Click += (sender, args) =>
            {
                string num_one, num_two, num_three, num_for, num_five, result;
                num_one = Picker.Value.ToString();
                num_two = picker.Value.ToString();
                num_three = numpicker.Value.ToString();
                num_for = picker4.Value.ToString();
                num_five = picker5.Value.ToString();
                result = num_one + num_two + num_three + num_for + num_five;
                Intent intent = new Intent(this, typeof(Numbers));
                intent.PutExtra("confirmation", result);
                StartActivity(intent);
                Finish();
            };
        }
    }
}