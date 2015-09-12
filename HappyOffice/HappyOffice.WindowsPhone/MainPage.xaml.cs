using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.Devices.Geolocation;
using System.Threading.Tasks;

namespace HappyOffice
{
    public sealed partial class MainPage : Page
    {
        private async void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
          
            Geolocator myGeolocator = new Geolocator();
            Geoposition myGeoposition = await myGeolocator.GetGeopositionAsync();
            Geocoordinate myGeocoordinate = myGeoposition.Coordinate;
            Point myPos = new Point
            {
                Username = TextInput.Text,
                Altitude = myGeocoordinate.Point.Position.Altitude,
                Latitude = myGeocoordinate.Point.Position.Latitude,
                Longitude = myGeocoordinate.Point.Position.Longitude,
                Desibel = 0,
                Lux = 0
            };
            await InsertTodoItem(myPos);
            await RefreshTodoItems();
            
        }
    }
}
