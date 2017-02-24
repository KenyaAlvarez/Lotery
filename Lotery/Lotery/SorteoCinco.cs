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
            var textcero = FindViewById<TextView>(Resource.Id.cero);

            var text = FindViewById<TextView>(Resource.Id.uno);
            var Numberpicker1 = FindViewById<NumberPicker>(Resource.Id.number1);

            Numberpicker1.MinValue = 1;
            Numberpicker1.MaxValue = 52;

            Numberpicker1.ValueChanged += (sender, args) =>
            {
                text.Text = args.NewVal.ToString();
            };

            var textdos = FindViewById<TextView>(Resource.Id.dos);
            var Numberpicker2 = FindViewById<NumberPicker>(Resource.Id.number2);

            Numberpicker2.MinValue = 1;
            Numberpicker2.MaxValue = 52;

            Numberpicker2.ValueChanged += (sender, args) =>
            {
                textdos.Text = args.NewVal.ToString();
            };

            var textres = FindViewById<TextView>(Resource.Id.tres);
            var Numberpicker3 = FindViewById<NumberPicker>(Resource.Id.number3);

            Numberpicker3.MinValue = 1;
            Numberpicker3.MaxValue = 52;

            Numberpicker3.ValueChanged += (sender, args) =>
            {
                textres.Text = args.NewVal.ToString();
            };

            var textcuatro = FindViewById<TextView>(Resource.Id.cuatro);
            var Numberpicker4 = FindViewById<NumberPicker>(Resource.Id.number4);

            Numberpicker4.MinValue = 1;
            Numberpicker4.MaxValue = 52;

            Numberpicker4.ValueChanged += (sender, args) =>
            {
                textcuatro.Text = args.NewVal.ToString();
            };

            var textcinco = FindViewById<TextView>(Resource.Id.cinco);
            var Numberpicker5 = FindViewById<NumberPicker>(Resource.Id.number5);

            Numberpicker5.MinValue = 1;
            Numberpicker5.MaxValue = 52;

            Numberpicker5.ValueChanged += (sender, args) =>
            {
               textcinco.Text = args.NewVal.ToString();
            };

            Button confirm_btn = FindViewById<Button>(Resource.Id.confirm);

            confirm_btn.Click += (sender, args) =>
            {
                string nuno, ndos, ntres, ncuatro, ncinco, result;
                nuno = Numberpicker1.Value.ToString();
                ndos = Numberpicker2.Value.ToString();
                ntres = Numberpicker3.Value.ToString();
                ncuatro = Numberpicker4.Value.ToString();
                ncinco = Numberpicker5.Value.ToString();
                result = nuno + ndos + ntres + ncuatro + ncinco;
                Intent intent = new Intent(this, typeof(Numbers));
                intent.PutExtra("confirmacion", result);
                StartActivity(intent);
                Finish();
            };
        }
    }
}