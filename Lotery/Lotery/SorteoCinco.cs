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
    [Activity(Label = "SorteoCinco")]
    public class SorteoCinco : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.Sort5);

            NumberPicker picker_one_s5 = FindViewById<NumberPicker>(Resource.Id.pickeruno_s5);
            NumberPicker picker_two_s5 = FindViewById<NumberPicker>(Resource.Id.pickerdos_s5);
            NumberPicker picker_three_s5 = FindViewById<NumberPicker>(Resource.Id.pickertres_s5);
            NumberPicker picker_four_s5 = FindViewById<NumberPicker>(Resource.Id.pickercuatro_s5);
            NumberPicker picker_five_s5 = FindViewById<NumberPicker>(Resource.Id.pickercinco_s5);

            picker_one_s5.MinValue = 1;
            picker_one_s5.MaxValue = 52;
            picker_two_s5.MinValue = 1;
            picker_two_s5.MaxValue = 52;
            picker_three_s5.MinValue = 1;
            picker_three_s5.MaxValue = 52;
            picker_four_s5.MinValue = 1;
            picker_four_s5.MaxValue = 52;
            picker_five_s5.MinValue = 1;
            picker_five_s5.MaxValue = 52;

            TextView n_one = FindViewById<TextView>(Resource.Id.text_1_s5);
            TextView n_two = FindViewById<TextView>(Resource.Id.text_2_s5);
            TextView n_three = FindViewById<TextView>(Resource.Id.text_3_s5);
            TextView n_for = FindViewById<TextView>(Resource.Id.text_4_s5);
            TextView n_five = FindViewById<TextView>(Resource.Id.text_5_s5);

            picker_one_s5.ValueChanged += (sender, args) =>
            {
                n_one.Text = args.NewVal.ToString();
            };

            picker_two_s5.ValueChanged += (sender, args) =>
            {
                n_two.Text = args.NewVal.ToString();
            };

            picker_three_s5.ValueChanged += (sender, args) =>
            {
                n_three.Text = args.NewVal.ToString();
            };

            picker_four_s5.ValueChanged += (sender, args) =>
            {
                n_for.Text = args.NewVal.ToString();
            };

            picker_five_s5.ValueChanged += (sender, args) =>
            {
                n_five.Text = args.NewVal.ToString();
            };

            Button confirm_btn = FindViewById<Button>(Resource.Id.confirm_s5);

            confirm_btn.Click += (sender, args) =>
            {
                string num_one, num_two, num_three, num_for, num_five, result;
                num_one = picker_one_s5.Value.ToString();
                num_two = picker_two_s5.Value.ToString();
                num_three = picker_three_s5.Value.ToString();
                num_for = picker_four_s5.Value.ToString();
                num_five = picker_five_s5.Value.ToString();

                result = num_one + num_two + num_three + num_for + num_five;
                Intent intent = new Intent(this, typeof(Numbers));
                intent.PutExtra("confirmacion", result);
                StartActivity(intent);
                Finish();
            };
        }
    }
}