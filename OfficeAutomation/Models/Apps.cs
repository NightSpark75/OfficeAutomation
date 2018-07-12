using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OfficeAutomation.Models
{
    public class Apps
    {
        public string id { get; set; }
        public string path { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int seq { get; set; }
        public bool active { get; set; }
        public string created_by { get; set; }
        public DateTime created_at { get; set; }
        public string deleted_by { get; set; }
        public DateTime dleeted_by { get; set; }
    }
}