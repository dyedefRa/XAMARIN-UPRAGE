using Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace App1.Extension
{
    public class MapPage : ContentPage
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
                MapType = MapType.Hybrid
            };
           
            Content = currentMap;
        }
    }
}