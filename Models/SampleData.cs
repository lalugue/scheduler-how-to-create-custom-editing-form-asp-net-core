using ASP.NET_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_NET_Core.Models {
    static class SampleData {
        public static List<SampleAppointment> Orders = new List<SampleAppointment>() {
            new SampleAppointment
            {
                ID = 1,
                Price = 10,
                StartDate = new DateTime(2015, 4, 25, 9, 10, 0),
                EndDate =  new DateTime(2015, 4, 25, 11, 1, 0),
                Text = "His Girl Friday",
                Director = "Howard Hawks",
                Year = 1940,
                Image = "https://js.devexpress.com/Demos/WidgetsGallery/JSDemos/images/movies/HisGirlFriday.jpg",
                Duration = 92
            }
        };
    }
}
