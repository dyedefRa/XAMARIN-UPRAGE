using System;
using System.Collections.Generic;
using System.Text;

namespace DataBinding.Pages.Sample1
{
    public class MyBindingObject
    {
        public string Description { get; set; } = "Test description";
        public int MyNumber { get; set; } = 45;
        public double MyDouble { get; set; } = 13.53d;
        public string ImageUrl { get; set; }
    }
}
