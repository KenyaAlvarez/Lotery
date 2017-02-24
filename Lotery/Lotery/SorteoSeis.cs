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
    [Activity(Label = "SorteoSeis")]
    public class SorteoSeis : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            var view = FindViewById<TextView>(Resource.Id.numbers);

            var viewuno = FindViewById<TextView>(Resource.Id.t_uno);
            var nuno = FindViewById<NumberPicker>(Resource.Id.np1);

            nuno.MinValue = 1;
            nuno.MaxValue = 52;

            nuno.ValueChanged += (sender, args) =>
            {
                viewuno.Text = args.NewVal.ToString();
            };

            var viewdos = FindViewById<TextView>(Resource.Id.t_dos);
            var ndos = FindViewById<NumberPicker>(Resource.Id.np2);

            ndos.MinValue = 1;
            ndos.MaxValue = 52;

            ndos.ValueChanged += (sender, args) =>
            {
                viewdos.Text = args.NewVal.ToString();
            };

            var viewtres = FindViewById<TextView>(Resource.Id.t_tres);
            var ntres = FindViewById<NumberPicker>(Resource.Id.np3);

            ntres.MinValue = 1;
            ntres.MaxValue = 52;

            ntres.ValueChanged += (sender, args) =>
            {
                viewtres.Text = args.NewVal.ToString();
            };

            var viewcuatro = FindViewById<TextView>(Resource.Id.t_cuatro);
            var ncuatro = FindViewById<NumberPicker>(Resource.Id.np4);

            ncuatro.MinValue = 1;
            ncuatro.MaxValue = 52;

            ncuatro.ValueChanged += (sender, args) =>
            {
                viewcuatro.Text = args.NewVal.ToString();
            };

            var viewcinco = FindViewById<TextView>(Resource.Id.t_cinco);
            var ncinco = FindViewById<NumberPicker>(Resource.Id.np5);

            ncinco.MinValue = 1;
            ncinco.MaxValue = 52;

            ncinco.ValueChanged += (sender, args) =>
            {
                viewcinco.Text = args.NewVal.ToString();
            };


            Button confirm_btn = FindViewById<Button>(Resource.Id.confirm);

            confirm_btn.Click += (sender, args) =>
            {
                string N1, N2, N3, N4, N5, result;
                N1 = nuno.Value.ToString();
                N2 = ndos.Value.ToString();
                N3 = ntres.Value.ToString();
                N4 = ncuatro.Value.ToString();
                N5 = ncinco.Value.ToString();
                result = N1 + N2 + N3 + N4 + N5;
                Intent intent = new Intent(this, typeof(Numbers));
                intent.PutExtra("confirmacion", result);
                StartActivity(intent);
                Finish();
            };

        }
    }
}