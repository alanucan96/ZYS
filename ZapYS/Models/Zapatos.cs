using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZapYS.Models
{
    public class Zapatos
    {
        public int ID { get; set; }
        public int talla { get; set; }
        public string modelo { get; set; }
        public string img { get; set; }
        public string genero { get; set; }
    }
}