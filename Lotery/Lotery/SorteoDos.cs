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
    [Activity(Label = "SorteoDos")]
    public class SorteoDos : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Sort2);
            //var txtcero = FindViewById<TextView>(Resource.Id.text0);


            var picker_one_s2 = FindViewById<NumberPicker>(Resource.Id.pickeruno_s2);
            var picker_two_s2 = FindViewById<NumberPicker>(Resource.Id.pickerdos_s2);
            var picker_three_s2 = FindViewById<NumberPicker>(Resource.Id.pickertres_s2);
            var picker_four_s2 = FindViewById<NumberPicker>(Resource.Id.pickercuatro_s2);
            var picker_five_s2 = FindViewById<NumberPicker>(Resource.Id.pickercinco_s2);

            var txt_one_s2 = FindViewById<TextView>(Resource.Id.text_1_s2);
            var txt_two_s2 = FindViewById<TextView>(Resource.Id.text_2_s2);
            var txt_three_s2 = FindViewById<TextView>(Resource.Id.text_3_s2);
            var txt_four_s2 = FindViewById<TextView>(Resource.Id.text_4_s2);
            var txt_five_s2 = FindViewById<TextView>(Resource.Id.text_5_s2);

            picker_one_s2.MinValue = 1;
            picker_one_s2.MaxValue = 52;
            picker_two_s2.MinValue = 1;
            picker_two_s2.MaxValue = 52;
            picker_three_s2.MinValue = 1;
            picker_three_s2.MaxValue = 52;
            picker_four_s2.MinValue = 1;
            picker_four_s2.MaxValue = 52;
            picker_five_s2.MinValue = 1;
            picker_five_s2.MaxValue = 52;

            picker_one_s2.ValueChanged += (sender, args) =>
            {
                txt_one_s2.Text = args.NewVal.ToString();
            };

            picker_two_s2.ValueChanged += (sender, args) =>
            {
                txt_two_s2.Text = args.NewVal.ToString();
            };

            picker_three_s2.ValueChanged += (sender, args) =>
            {
                txt_three_s2.Text = args.NewVal.ToString();
            };

            picker_four_s2.ValueChanged += (sender, args) =>
            {
                txt_four_s2.Text = args.NewVal.ToString();
            };

            picker_five_s2.ValueChanged += (sender, args) =>
            {
                txt_five_s2.Text = args.NewVal.ToString();
            };

            Button confirm_btn = FindViewById<Button>(Resource.Id.confirm_s2);

            confirm_btn.Click += (sender, args) =>
            {
                string uno, dos, tres, cuatro, cinco, result;
                uno = picker_one_s2.Value.ToString();
                dos = picker_two_s2.Value.ToString();
                tres = picker_three_s2.Value.ToString();
                cuatro = picker_four_s2.Value.ToString();
                cinco = picker_five_s2.Value.ToString();

                result = uno + dos + tres + cuatro + cinco;
                Intent intent = new Intent(this, typeof(Numbers));
                intent.PutExtra("confirmacion", result);
                StartActivity(intent);
                Finish();
            };
        }
    }
}