using System;
using System.Collections.Generic;
using System.Text;

namespace TMS.API.Core.Models
{

        public class Patch
        {
            public string small { get; set; }
            public string large { get; set; }
        }

        public class Reddit
        {
            public string campaign { get; set; }
            public string launch { get; set; }
            public string media { get; set; }
            public object recovery { get; set; }
        }

        public class Flickr
        {
            public IList<object> small { get; set; }
            public IList<object> original { get; set; }
        }

        public class Links
        {
            public Patch patch { get; set; }
            public Reddit reddit { get; set; }
            public Flickr flickr { get; set; }
            public object presskit { get; set; }
            public string webcast { get; set; }
            public string youtube_id { get; set; }
            public object article { get; set; }
            public string wikipedia { get; set; }
        }

        public class Cores
        {
            public string core { get; set; }
            public int flight { get; set; }
            public bool gridfins { get; set; }
            public bool legs { get; set; }
            public bool reused { get; set; }
            public bool landing_attempt { get; set; }
            public bool landing_success { get; set; }
            public string landing_type { get; set; }
            public string landpad { get; set; }
        }

        public class Example
        {
            public object fairings { get; set; }
            public Links links { get; set; }
            public DateTime static_fire_date_utc { get; set; }
            public int static_fire_date_unix { get; set; }
            public bool tbd { get; set; }
            public bool net { get; set; }
            public object window { get; set; }
            public string rocket { get; set; }
            public bool success { get; set; }
            public string details { get; set; }
            public IList<string> crew { get; set; }
            public IList<string> ships { get; set; }
            public IList<string> capsules { get; set; }
            public IList<string> payloads { get; set; }
            public string launchpad { get; set; }
            public bool auto_update { get; set; }
            public IList<object> failures { get; set; }
            public int flight_number { get; set; }
            public string name { get; set; }
            public DateTime date_utc { get; set; }
            public int date_unix { get; set; }
            public DateTime date_local { get; set; }
            public string date_precision { get; set; }
            public bool upcoming { get; set; }
            public IList<Cores> cores { get; set; }
            public string id { get; set; }
        }
}
