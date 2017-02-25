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
    [Activity(Label = "Ticket")]
    public class Ticket : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Recibo);

            TextView Nombre = FindViewById<TextView>(Resource.Id.nombre);
            TextView Sorteo = FindViewById<TextView>(Resource.Id.sorteo);
            TextView Fecha = FindViewById<TextView>(Resource.Id.fecha);
            TextView Boleto = FindViewById<TextView>(Resource.Id.boleto);
            TextView Combinacion = FindViewById<TextView>(Resource.Id.combinacion);

            Nombre.Text = "Rafael Gomez";

            Combinacion.Text = Intent.GetStringExtra("n_to_ticket").ToString();

            string diaHoy = DateTime.Now.Day.ToString();
            string mesHoy = DateTime.Now.Month.ToString();
            string añoHoy = DateTime.Now.Year.ToString();

            string fechaCompleta = diaHoy + " - " + mesHoy + " - " + añoHoy;
            Fecha.Text = fechaCompleta;

            Boleto.Text = "98765433";
            Sorteo.Text = "12345678";

            Button btn_quit = FindViewById<Button>(Resource.Id.btnhecho);

            btn_quit.Click += delegate
              {
                  Finish();
              };
        }
    }
}