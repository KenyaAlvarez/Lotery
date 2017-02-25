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
    [Activity(Label = "Sorteo Mayor")]
    public class SorteoTres : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.Sort3);

            var picker_one_s3 = FindViewById<NumberPicker>(Resource.Id.pickeruno_s3);
            var picker_two_s3 = FindViewById<NumberPicker>(Resource.Id.pickerdos_s3);
            var picker_three_s3 = FindViewById<NumberPicker>(Resource.Id.pickertres_s3);
            var picker_four_s3 = FindViewById<NumberPicker>(Resource.Id.pickercuatro_s3);
            var picker_five_s3 = FindViewById<NumberPicker>(Resource.Id.pickercinco_s3);

            var n_one = FindViewById<TextView>(Resource.Id.text_1_s3);
            var n_two = FindViewById<TextView>(Resource.Id.text_2_s3);
            var n_three = FindViewById<TextView>(Resource.Id.text_3_s3);
            var n_for = FindViewById<TextView>(Resource.Id.text_4_s3);
            var n_five = FindViewById<TextView>(Resource.Id.text_5_s3);

            picker_one_s3.MinValue = 1;
            picker_one_s3.MaxValue = 52;
            picker_two_s3.MinValue = 1;
            picker_two_s3.MaxValue = 52;
            picker_three_s3.MinValue = 1;
            picker_three_s3.MaxValue = 52;
            picker_four_s3.MinValue = 1;
            picker_four_s3.MaxValue = 52;
            picker_five_s3.MinValue = 1;
            picker_five_s3.MaxValue = 52;

            picker_one_s3.ValueChanged += (sender, args) =>
            {
                n_one.Text = args.NewVal.ToString();
            };

            picker_two_s3.ValueChanged += (sender, args) =>
            {
                n_two.Text = args.NewVal.ToString();
            };

            picker_three_s3.ValueChanged += (sender, args) =>
            {
                n_three.Text = args.NewVal.ToString();
            };

            picker_four_s3.ValueChanged += (sender, args) =>
            {
                n_for.Text = args.NewVal.ToString();
            };

            picker_five_s3.ValueChanged += (sender, args) =>
            {
                n_five.Text = args.NewVal.ToString();
            };

            Button confirm_btn = FindViewById<Button>(Resource.Id.confirm_s3);

            confirm_btn.Click += (sender, args) =>
            {
                string num_one, num_two, num_three, num_for, num_five, result;
                num_one = picker_one_s3.Value.ToString();
                num_two = picker_two_s3.Value.ToString();
                num_three = picker_three_s3.Value.ToString();
                num_for = picker_four_s3.Value.ToString();
                num_five = picker_five_s3.Value.ToString();

                result = num_one + num_two + num_three + num_for + num_five;
                Intent intent = new Intent(this, typeof(Numbers));
                intent.PutExtra("confirmacion", result);
                StartActivity(intent);
                Finish();
            };
        }
    }
}