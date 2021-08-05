using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace AcikAkademiDersleri
{
    public class MapPage:ContentPage
    {
        public MapPage()
        {
            CreateMap();
        }

        private void CreateMap()
        {
            Map currentMap = new Map()
            {
                HasScrollEnabled = true,
                HasZoomEnabled = true,
                MapType = MapType.Street
            };

            currentMap.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                new Position(41.0707118, 29.0154514), Distance.FromMiles(10)));
            Content = currentMap;
        }
    }
}
