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
            SetContentView(Resource.Layout.Sort3);

            var textview0 = FindViewById<TextView>(Resource.Id.text0);

            var textview1 = FindViewById<TextView>(Resource.Id.text1);
            var Numberuno = FindViewById<NumberPicker>(Resource.Id.pickerUno);

            Numberuno.MinValue = 1;
            Numberuno.MaxValue = 52;

            Numberuno.ValueChanged += (sender, args) =>
            {
                textview1.Text = args.NewVal.ToString();
            };


            var textview2 = FindViewById<TextView>(Resource.Id.text2);
            var Numberdos = FindViewById<NumberPicker>(Resource.Id.pickerDos);

            Numberdos.MinValue = 1;
            Numberdos.MaxValue = 52;

            Numberdos.ValueChanged += (sender, args) =>
            {
                textview2.Text = args.NewVal.ToString();
            };

            var textview3 = FindViewById<TextView>(Resource.Id.text3);
            var Numbertres = FindViewById<NumberPicker>(Resource.Id.pickerTres);

            Numbertres.MinValue = 1;
            Numbertres.MaxValue = 52;

            Numbertres.ValueChanged += (sender, args) =>
            {
                textview3.Text = args.NewVal.ToString();
            };

            var textview4 = FindViewById<TextView>(Resource.Id.text4);
            var Numbercuatro = FindViewById<NumberPicker>(Resource.Id.pickerCuatro);

            Numbercuatro.MinValue = 1;
            Numbercuatro.MaxValue = 52;

            Numbercuatro.ValueChanged += (sender, args) =>
            {
                textview4.Text = args.NewVal.ToString();
            };

            var textview5 = FindViewById<TextView>(Resource.Id.text5);
            var Numbercinco = FindViewById<NumberPicker>(Resource.Id.pickerCinco);

            Numbercinco.MinValue = 1;
            Numbercinco.MaxValue = 52;

            Numbercinco.ValueChanged += (sender, args) =>
            {
                textview5.Text = args.NewVal.ToString();
            };

            Button confirm_btn = FindViewById<Button>(Resource.Id.confirm);

            confirm_btn.Click += (sender, args) =>
            {
                string Uno, Dos, Tres, Cuatro, Cinco, result;
                Uno = Numberuno.Value.ToString();
                Dos = Numberdos.Value.ToString();
                Tres = Numbertres.Value.ToString();
                Cuatro = Numbercuatro.Value.ToString();
                Cinco = Numbercinco.Value.ToString();
                result = Uno + Dos + Tres +  Cuatro + Cinco;
                Intent intent = new Intent(this, typeof(Numbers));
                intent.PutExtra("confirmacion", result);
                StartActivity(intent);
                Finish();
            };
        }
    }
}