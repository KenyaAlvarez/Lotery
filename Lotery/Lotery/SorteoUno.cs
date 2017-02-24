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

            NumberPicker picker_one_s1 = FindViewById<NumberPicker>(Resource.Id.picker_uno_s1);
            NumberPicker picker_two_s1 = FindViewById<NumberPicker>(Resource.Id.picker_dos_s1);
            NumberPicker picker_three_s1 = FindViewById<NumberPicker>(Resource.Id.picker_tres_s1);
            NumberPicker picker_four_s1 = FindViewById<NumberPicker>(Resource.Id.picker_cuatro_s1);
            NumberPicker picker_five_s1 = FindViewById<NumberPicker>(Resource.Id.picker_cinco_s1);

            picker_one_s1.MinValue = 1;
            picker_one_s1.MaxValue = 52;
            picker_two_s1.MinValue = 1;
            picker_two_s1.MaxValue = 52;
            picker_three_s1.MinValue = 1;
            picker_three_s1.MaxValue = 52;
            picker_four_s1.MinValue = 1;
            picker_four_s1.MaxValue = 52;
            picker_five_s1.MinValue = 1;
            picker_five_s1.MaxValue = 52;

            TextView n_one = FindViewById<TextView>(Resource.Id.text_1_s1);
            TextView n_two = FindViewById<TextView>(Resource.Id.text_2_s1);
            TextView n_three = FindViewById<TextView>(Resource.Id.text_3_s1);
            TextView n_for = FindViewById<TextView>(Resource.Id.text_4_s1);
            TextView n_five = FindViewById<TextView>(Resource.Id.text_5_s1);

            picker_one_s1.ValueChanged += (sender, args) =>
            {
                n_one.Text = args.NewVal.ToString();
            };

            picker_two_s1.ValueChanged += (sender, args) =>
            {
                n_two.Text = args.NewVal.ToString();
            };

            picker_three_s1.ValueChanged += (sender, args) =>
            {
                n_three.Text = args.NewVal.ToString();
            };
            picker_four_s1.ValueChanged += (sender, args) =>
            {
                n_for.Text = args.NewVal.ToString();
            };
            picker_five_s1.ValueChanged += (sender, args) =>
            {
                n_five.Text = args.NewVal.ToString();
            };

            Button confirm_btn = FindViewById<Button>(Resource.Id.confirm_s1);

            confirm_btn.Click += (sender, args) =>
            {
                string num_one, num_two, num_three, num_for, num_five, result;
                num_one = picker_one_s1.Value.ToString();
                num_two = picker_two_s1.Value.ToString();
                num_three = picker_three_s1.Value.ToString();
                num_for = picker_four_s1.Value.ToString();
                num_five = picker_five_s1.Value.ToString();

                result = num_one + num_two + num_three + num_for + num_five;
                Intent intent = new Intent(this, typeof(Numbers));
                intent.PutExtra("confirmacion", result);
                StartActivity(intent);
                Finish();
            };
        }
    }
}

