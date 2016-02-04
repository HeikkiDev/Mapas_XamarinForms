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
using Xamarin.Forms;
using Mapas_XF;
using Mapas_XF.Android.CustomRenderers;
using Xamarin.Forms.Maps.Android;
using Android.Gms.Maps;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Maps;
using Android.Gms.Maps.Model;

[assembly: ExportRenderer(typeof(MyBaseMap), typeof(MyMapRenderer))]
namespace Mapas_XF.Android.CustomRenderers
{
    /// <summary>
    /// Renderer for the xamarin map.
    /// Enable user to get a position by taping on the map.
    /// </summary>
    public class MyMapRenderer : MapRenderer, IOnMapReadyCallback
    {
        // We use a native google map for Android
        private GoogleMap _map;

        public void OnMapReady(GoogleMap googleMap)
        {
            _map = googleMap;

            if (_map != null)
                _map.MapClick += googleMap_MapClick;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e)
        {
            if (_map != null)
                _map.MapClick -= googleMap_MapClick;

            base.OnElementChanged(e);

            if (Control != null)
                ((MapView)Control).GetMapAsync(this);
        }

        private void googleMap_MapClick(object sender, GoogleMap.MapClickEventArgs e)
        {
            ((MyBaseMap)Element).OnTap(new Position(e.Point.Latitude, e.Point.Longitude));

            // Borramos el anterior Pin
            _map.Clear();

            var pinMarker = new MarkerOptions();
            pinMarker.SetPosition(new LatLng(e.Point.Latitude, e.Point.Longitude));
            pinMarker.SetTitle("Punto de encuentro :)");
            pinMarker.DescribeContents();
            setAdress(pinMarker, e);

            // Añado el pin al mapa
            _map.AddMarker(pinMarker).ShowInfoWindow();
        }

        private async void setAdress(MarkerOptions pinMarker, GoogleMap.MapClickEventArgs e)
        {
            string adress = "";
            // Obtengo la posible dirección a partir de la latitud y longitud
            Geocoder geocoder = new Geocoder();
            IEnumerable<string> possibleAdresses = await geocoder.GetAddressesForPositionAsync(new Position(e.Point.Latitude, e.Point.Longitude));

            adress = possibleAdresses.ElementAt(0);
            pinMarker.SetTitle(adress);

            // Añado el pin al mapa
            _map.AddMarker(pinMarker).ShowInfoWindow();

            // Comparto el punto en App
            var myApp = App.Current as App;
            myApp.meetingPoint = new MeetingPoint
            {
                Name = adress,
                Place = new Position(e.Point.Latitude, e.Point.Longitude)
            };
        }
    }
}
