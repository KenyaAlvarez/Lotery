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
    [Activity(Label = "Sorteo")]
    public class SorteoUno : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.Sort1);

            NumberPicker Picker = FindViewById<NumberPicker>(Resource.Id.pickeruno);
            NumberPicker picker = FindViewById<NumberPicker>(Resource.Id.pickerdos);
            NumberPicker numberpicker = FindViewById<NumberPicker>(Resource.Id.pickertres);
            NumberPicker picker4 = FindViewById<NumberPicker>(Resource.Id.pickercuatro);
            NumberPicker picker5 = FindViewById<NumberPicker>(Resource.Id.picker_cinco);

            Picker.MinValue = 1;
            Picker.MaxValue = 52;
            picker.MinValue = 1;
            picker.MaxValue = 52;
            numberpicker.MinValue = 1;
            numberpicker.MaxValue = 52;
            picker4.MinValue = 1;
            picker4.MaxValue = 52;
            picker5.MinValue = 1;
            picker5.MaxValue = 52;

            TextView n_one = FindViewById<TextView>(Resource.Id.text_1);
            TextView n_two = FindViewById<TextView>(Resource.Id.text_2);
            TextView n_three = FindViewById<TextView>(Resource.Id.text_3);
            TextView n_for = FindViewById<TextView>(Resource.Id.text_4);
            TextView n_five = FindViewById<TextView>(Resource.Id.text_5);

            Picker.ValueChanged += (sender, args) =>
            {
                n_one.Text = args.NewVal.ToString();
            };
            picker.ValueChanged += (sender, args) =>
            {
                n_two.Text = args.NewVal.ToString();
            };
            numberpicker.ValueChanged += (sender, args) =>
            {
                n_three.Text = args.NewVal.ToString();
            };
            picker4.ValueChanged += (sender, args) =>
            {
                n_for.Text = args.NewVal.ToString();
            };
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
                num_three = numberpicker.Value.ToString();
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
     
