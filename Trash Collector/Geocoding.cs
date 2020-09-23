using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Collector
{
    public static class Geocoding
    {
        const string url = "https://maps.googleapis.com/maps/api/geocode/json?address=1600+Amphitheatre+Parkway,+Mountain+View,+CA&key=@{apiKey}";
        const string apiKey = "AIzaSyChq1zDuvHeNkaqGJldW1dtU8EQgHZkz14";

        //public static Coordinates GetCoordinates()
        //{
        //    string urlParameters = $"search?entity_id=59&entity_type=city&apikey={apiKey}";
        //    var response = APICall.RunAsync<Coordinates>(url, urlParameters).GetAwaiter().GetResult();
        //    return response;
        //}
    }
}
