using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Patient
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string sex { get; set; }
        public string dateOfBirth { get; set; }
       
    }
}
