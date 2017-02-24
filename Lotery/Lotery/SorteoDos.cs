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
            var txtcero = FindViewById<TextView>(Resource.Id.text0);

            var txt = FindViewById<TextView>(Resource.Id.text1);
            var numberpicker = FindViewById<NumberPicker>(Resource.Id.Pickeruno);

            numberpicker.MinValue = 1;
            numberpicker.MaxValue = 52;

            numberpicker.ValueChanged += (sender, args) =>
            {
                txt.Text = args.NewVal.ToString();
            };

            var txtdos = FindViewById<TextView>(Resource.Id.text2);
            var number = FindViewById<NumberPicker>(Resource.Id.Pickerdos);

            number.MinValue = 1;
            number.MaxValue = 52;

            number.ValueChanged += (sender, args) =>
            {
                txtdos.Text = args.NewVal.ToString();
            };

            var texttres = FindViewById<TextView>(Resource.Id.text3);
            var numbertres = FindViewById<NumberPicker>(Resource.Id.Pickertres);

            numbertres.MinValue = 1;
            numbertres.MaxValue = 52;

            numbertres.ValueChanged += (sender, args) =>
            {
                texttres.Text = args.NewVal.ToString();
            };

            var txtcuatro = FindViewById<TextView>(Resource.Id.text4);
            var numbercuatro = FindViewById<NumberPicker>(Resource.Id.Pickercuatro);

            numbercuatro.MinValue = 1;
            numbercuatro.MaxValue = 52;

            numbercuatro.ValueChanged += (sender, args) =>
            {
                txtcuatro.Text = args.NewVal.ToString();
            };

            var txtcinco = FindViewById<TextView>(Resource.Id.text5);
            var numbercinco = FindViewById<NumberPicker>(Resource.Id.Pickercinco);

            numbercinco.MinValue = 1;
            numbercinco.MaxValue = 52;

            numbercinco.ValueChanged += (sender, args) =>
            {
                txtcinco.Text = args.NewVal.ToString();
            };

            Button confirm_btn = FindViewById<Button>(Resource.Id.confirm);

            confirm_btn.Click += (sender, args) =>
            {
                string uno, dos, tres, cuatro, cinco, result;
                uno = numberpicker.Value.ToString();
                dos = number.Value.ToString();
                tres = numbertres.Value.ToString();
                cuatro = numbercuatro.Value.ToString();
                cinco = numbercinco.Value.ToString();
                result = uno + dos + tres + cuatro + cinco;
                Intent intent = new Intent(this, typeof(Numbers));
                intent.PutExtra("confirmacion", result);
                StartActivity(intent);
                Finish();
            };


        }
    }
}