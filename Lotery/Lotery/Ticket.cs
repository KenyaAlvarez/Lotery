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

            // Create your application here

            SetContentView(Resource.Layout.Recibo);

            TextView Nombre = FindViewById<TextView>(Resource.Id.nombre);

            TextView Sorteo = FindViewById<TextView>(Resource.Id.sorteo);

            TextView Fecha = FindViewById<TextView>(Resource.Id.fecha);

            TextView Boleto = FindViewById<TextView>(Resource.Id.boleto);

            TextView Combinacion = FindViewById<TextView>(Resource.Id.combinacion);

           
        }
    }
}