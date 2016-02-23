using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;

namespace Remainer.Models
{
   public class RestaurantLocation
    {
     [Key]
        public int IdLocation { get; set; }
        public string Phone { get; set; }
        public string HoursOfOperation { get; set; }
       

    }
}
