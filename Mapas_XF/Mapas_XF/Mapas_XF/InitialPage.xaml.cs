using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Mapas_XF
{
    public partial class InitialPage : ContentPage
    {
        public InitialPage()
        {
            InitializeComponent();
            //

            Button buttonAdd = new Button
            {
                Text = "Añade un lugar",
                BackgroundColor = Color.White,
                BorderColor = Color.Blue,
                TextColor = Color.Black
            };
            buttonAdd.Clicked += ButtonAdd_Clicked;

            // Representa la instancia actual de la aplicación
            var myApp = Application.Current as App;

            // El contexto de datos del ListView es la lista que tenemos en App
            listViewPoints.ItemsSource = myApp.listaPuntos;

            // Evento Click sobre cada Item del ListView
            listViewPoints.ItemSelected += OnSelection;
            

            // Contenuido de la página, organizado en un StackLayout vertical
            Content = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = {
                    new Label {
                        Text = "Lugares de encuentro",
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontSize = 28,
                        FontAttributes = FontAttributes.Bold,
                        FontFamily = Font.Default.FontFamily
                    },
                    buttonAdd,
                    listViewPoints
                }
            };
        }

        private async void ButtonAdd_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.IsEnabled = false;  //Deshabilitado

            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 10;

            var position = await locator.GetPositionAsync(10000);

            // Navega a la página del mapa con la posición indicada
            Navigation.PushAsync(new MapPage(position.Latitude, position.Longitude), true);

            btn.IsEnabled = true; // Habilitado
        }

        private void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }

            MeetingPoint mp = ((ListView)sender).SelectedItem as MeetingPoint;

            DisplayAlert("Item Selected: ", "Lugar: "+mp.Name+"\nLat: "+mp.Place.Latitude+"\nLong: "+mp.Place.Longitude, "Ok");
            ((ListView)sender).SelectedItem = null; //deshabilita la selección (para que no mantenga el color de fondo)
        }
    }
}
