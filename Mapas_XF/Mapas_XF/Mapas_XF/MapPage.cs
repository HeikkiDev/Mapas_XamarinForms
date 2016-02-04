using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Mapas_XF
{
    public class MapPage : ContentPage
    {
        Map map;

        public MapPage(double latitude, double longitude)
        {
            map = new MyBaseMap(
            MapSpan.FromCenterAndRadius(
                    new Position(latitude, longitude), Distance.FromKilometers(0.5)))
            {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            map.MapType = MapType.Street;

            Button buttonSave = new Button {
                Text = "Guardar lugar de encuentro",
                TextColor = Color.Black,
                BackgroundColor = Color.White,
                BorderColor = Color.Blue
            };
            buttonSave.Clicked += ButtonSave_Clicked;

            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            stack.Children.Add(buttonSave);
            // Contenido de la página
            Content = stack;
        }

        private void ButtonSave_Clicked(object sender, EventArgs e)
        {
            var myApp = Application.Current as App;
            myApp.listaPuntos.Add(myApp.meetingPoint);  //Nuevo punto añadido
            Navigation.PopAsync();  // Navego atrás en la pila de navegación
        }

        private void AddPinPosition(double latitude, double longitude)
        {
            var position = new Position(latitude, longitude);

            var pin = new Pin
            {
                Type = PinType.Generic,
                Position = position,
                Label = "Punto de encuentro",
                Address = "una dirección cualquiera..."
            };

            map.Pins.Add(pin);
        }

        private void MoveToRegion(double latitude, double longitude)
        {
            map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(latitude, longitude),
                Distance.FromKilometers(1.5)));
        }
    }
}
