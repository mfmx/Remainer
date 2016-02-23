using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;


namespace Remainer.Models
{
   public class RestaurantLocationContext : DbContext
    {
        public  RestaurantLocationContext()
            : base("RemainerDb")
        {
        }

        public DbSet<RestaurantLocation> RestaurantLocations { get; set; }
    }
}
