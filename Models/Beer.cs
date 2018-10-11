using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DuserORM_MySQL
{
    public class Beer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Category_id { get; set; }
        public string Description { get; set; }
        public string Alcohol { get; set; }
        public string Color { get; set; }
        public string IBU { get; set; }
        public string Yeast { get; set; }
        public string Image { get; set; }
        
    }
}