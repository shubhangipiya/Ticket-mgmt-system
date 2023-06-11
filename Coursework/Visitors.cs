using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class Visitors
    {
        public string VisitorsID { get; set; }
        public string VisitorsName { get; set; }
        public string PhoneNo { get; set; }
        public string Price { get; set; }
        public string AgeGroup { get; set; }
        public string Duration { get; set; }
        public string GroupNo { get; set; }
        public string InTime { get; set; }
        public string OutTime { get; set; }

        public string VisitorsDateTime { get; set; }
        public string Day{get; set; }

        public List<Visitors> List()
        {
            string d = Utility.ReadToText();
            if (d != null)
            {
                List<Visitors> lst = JsonConvert.DeserializeObject<List<Visitors>>(d);
                return lst;
            }
            return null;
        }

    }
}
